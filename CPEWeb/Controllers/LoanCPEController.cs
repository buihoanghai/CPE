using CPEWeb.Class;
using DAL.Implement.CPE_vs1DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CPEWeb.Controllers
{
    public class LoanCPEController : Controller
    {
        #region variable
        ICustomersDAL _DALCustomer = new CustomersDAL();
        ILoansDAL _DALLoan = new LoansDAL();
        ILoanDetailsDAL _DALLoanDetail = new LoanDetailsDAL();
        ICPEGlobalsDAL _DALCPEGlobal = new CPEGlobalsDAL();
        IPromotionsDAL _DALPromotion = new PromotionsDAL();
        IPackagesDAL _DALPackage = new PackagesDAL();
        #endregion

        #region method
        float _checkCountRent(LoanInfo loaninf)
        {
            try
            {
                int dayRent = (Convert.ToDateTime(loaninf.ReturnDate) - Convert.ToDateTime(loaninf.CollectionDate)).Days;
                float rentAmount = 0;
                var package = _DALPackage.SelectAll();
                while (dayRent > 0)
                {
                    for (int i = package.Count - 1; i >= 0; i--)
                    {
                        var item = package[i];
                        if (dayRent >= (int)item.Days)
                        {
                            rentAmount += (float)Convert.ToDecimal(item.Price);
                            dayRent = dayRent - (int)item.Days;
                            break;
                        }
                    }
                }
                return rentAmount;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        void _checkAndcalcuLoan(LoanInfo item)
        {
            if (item.CollectionDate == null)
                item.CollectionDate = DateTime.Now.Date;
            if (item.ReturnDate == null)
                item.ReturnDate = DateTime.Now.AddDays(3).Date;
            if ((DateTime.Now.Date > Convert.ToDateTime(item.CollectionDate).Date))
                item.CollectionDate = DateTime.Now.Date;
            if ((Convert.ToDateTime(item.ReturnDate) - Convert.ToDateTime(item.CollectionDate)).Days < 3)
                item.ReturnDate = Convert.ToDateTime(item.CollectionDate).AddDays(3);

            if (item.RentalMode == "Delivery")
                item.Delivery = 14;
            else
                item.Delivery = 0;
            item.RentalPrice = _checkCountRent(item) * item.DeviceQuantity;
            if (_DALPromotion.CheckByPromotionCode(item.Agent_Promotion_Code))
            {
                var promo = _DALPromotion.SelectByPromotionCode(item.Agent_Promotion_Code);
                item.OnlineDiscount = ((float)promo.Discount * item.RentalPrice) / 100;
            }
            else
                item.OnlineDiscount = 0;
            item.Total = item.RentalPrice + item.Delivery - item.OnlineDiscount;
            PublicClass._loanInfo = item;
        }

        void _saveLoanInfoAndLoanDetail()
        {

            _saveLoanInfo();
            _saveLoanDetail();
        }
        private void _saveLoanDetail()
        {
            bool flag = false;
            LoanDetail ld = new LoanDetail();
            for (int i = 0; i < PublicClass._loanInfo.DeviceQuantity; i++)
            {
                if (!flag)
                {
                    ld.Created = DateTime.Now.Date;
                    ld.Deposit = _DALCPEGlobal.SelectByID(1).Deposit;
                    ld.Loan_ID = PublicClass._LoanCur.ID;
                    ld.LoanDate = PublicClass._loanInfo.CollectionDate;
                    Promotion pro = _DALPromotion.SelectByPromotionCode(PublicClass._loanInfo.Agent_Promotion_Code);
                    if (pro != null && pro.ID != 0)
                    {
                        ld.PromotionDisCount = pro.Discount;
                    }
                    float rent = _checkCountRent(PublicClass._loanInfo);
                    if (pro != null && pro.ID != 0)
                        ld.RentAmount = rent - (rent * ld.PromotionDisCount) / 100;
                    else
                        ld.RentAmount = rent;
                    ld.RentDay = (Convert.ToDateTime(PublicClass._loanInfo.ReturnDate).Date - Convert.ToDateTime(PublicClass._loanInfo.CollectionDate).Date).Days;
                    ld.ReturnDate = PublicClass._loanInfo.ReturnDate;
                    ld.SiteLoan_ID = PublicClass._loanInfo.CollectionLocation;
                    ld.Status = 7;
                    ld.CPE_ID = 0;
                    ld.AgentCode = PublicClass._loanInfo.AgentCode;
                    ld.PenaltyAmount = 0;
                    flag = true;
                }
                if (flag)
                    _DALLoanDetail.Insert(ld);
            }
        }
        void _saveCustomer()
        {
            PublicClass._customerCur.Created = DateTime.Now.Date;
            Customer cus = PublicClass._convertCustomerInfoToCustomer(PublicClass._customerCur);
            _DALCustomer.Insert(cus);
            PublicClass._customerCur.ID = _DALCustomer.GetMaxID();
        }
        void _saveLoanInfo()
        {
            
            Loan l = new Loan();
            l.Created = DateTime.Now.Date;
            l.CreditCardNumer = PublicClass._loanInfo.CreditCardNumer;
            l.Customer_ID = PublicClass._customerCur.ID;
            l.CustomerCode = PublicClass._loanInfo.CustomerCode;
            l.Delivery = PublicClass._loanInfo.Delivery;
            l.LoanSiteID = PublicClass._loanInfo.CollectionLocation;
            l.OnlineDiscount = PublicClass._loanInfo.OnlineDiscount;
            l.OnlineDiscountCode = PublicClass._loanInfo.Agent_Promotion_Code;
            l.RentalPrice = PublicClass._loanInfo.RentalPrice;
            l.ReturnType = PublicClass._loanInfo.RentalMode;
            l.Status = 1;
            l.SubTotal = PublicClass._loanInfo.Total;
            l.NameOnCard = PublicClass._loanInfo.NameOnCard;
            l.ExpiredateCreditCard = PublicClass._loanInfo.ExpiredateCreditCard;
            l.BookedName = PublicClass._loanInfo.BookedName;
            l.DeliveryAddress = PublicClass._loanInfo.DeliveryAddress;
            _DALLoan.Insert(l);
            PublicClass._LoanCur = l;
            PublicClass._LoanCur.ID = _DALLoan.GetMaxID();
        }
        void _saveCustomerAndLoan()
        {
            _saveCustomer();
            _saveLoanInfoAndLoanDetail();
        }
        private static void _newInfo()
        {
            PublicClass._customerCur = new CustomerInfo();
            PublicClass._loanInfo = new LoanInfo();
            PublicClass._LoanCur = new Loan();
            PublicClass._delivery = null;
            PublicClass._selfReturn = null;
        }
        private static void _CheckGetCustomerCode()
        {
            if (PublicClass._loanInfo.CustomerCode == "" || PublicClass._loanInfo.CustomerCode == null)
            {
                string path = Path.GetRandomFileName();
                path = path.Replace(".", "").ToUpper();
                PublicClass._loanInfo.CustomerCode = path;
            }
        }
        #endregion
        public ActionResult Index()
        {
            _newInfo();
            return View();
        }

        public ActionResult InnerCustomer()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            _checkAndcalcuLoan(PublicClass._loanInfo);
            return View(PublicClass._customerCur);
        }
        [HttpPost]
        public ActionResult InnerCustomer(CustomerInfo item, string Expiry_date1, string DOB1)
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            if (ModelState.IsValid)
            {
                if (item.DrivingLisence == "Passport"){
                    item.DrivingLisence = null;
                    if (Expiry_date1 != "")
                        item.Expiry_date = DateTime.ParseExact(Expiry_date1, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                    
                }
                else if (item.DrivingLisence == "DrivingLisence")
                {
                    item.DrivingLisence = item.Passport;
                    item.Passport = null;
                    item.Expiry_date = null;

                }
                else
                {
                    item.IDLisence = item.Passport;
                    item.DrivingLisence = null;
                    item.Passport = null;
                    item.Expiry_date = null;

                }
                if (DOB1 != "")
                    item.DOB = DateTime.ParseExact(DOB1, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                string path = Path.GetRandomFileName();
                path = path.Replace(".", "").ToUpper();
                PublicClass._loanInfo.CustomerCode = path;
                PublicClass._customerCur = item;
                if (PublicClass._delivery != null)
                    return RedirectToAction("DeliveryPayment");
                else
                    return RedirectToAction("SelfPayment");
            }
            else
                return View(item);
        }

        public ActionResult DeliveryPayment()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            _CheckGetCustomerCode();
            return View(new CreditCard());
        }
        [HttpPost]
        public ActionResult DeliveryPayment(CreditCard item, string ExpireDate1)
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            if (ModelState.IsValid)
            {
                PublicClass._loanInfo.NameOnCard = item.NameOnCard;
                PublicClass._loanInfo.CreditCardNumer = item.CardNumber;
                if (ExpireDate1 != "")
                    PublicClass._loanInfo.ExpiredateCreditCard = DateTime.ParseExact(ExpireDate1, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                //PublicClass._loanInfo.ExpiredateCreditCard = item.ExpireDate;
                if(PublicClass._customerCur.ID==0)
                return RedirectToAction("DeliveryConfirm");
                else
                    return RedirectToAction("DeliveryConfirmWithLogin");
            }
            else
            {
                return View(item);
            }
        }
        public ActionResult SelfPayment()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            _CheckGetCustomerCode();
            return View();
        }

        

        public ActionResult DeliveryConfirmWithLogin()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            return View();
        }
        [HttpPost]
        public ActionResult DeliveryConfirmWithLogin1()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");

            _saveLoanInfoAndLoanDetail();

            _newInfo();
            return RedirectToAction("Index", "LoanCPE");
        }
        public ActionResult DeliveryConfirm()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            return View(new Register());
        }
        [HttpPost]
        public ActionResult DeliveryConfirm(Register item)
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            if (ModelState.IsValid)
            {
                PublicClass._customerCur.UserName = item.UserName;
                PublicClass._customerCur.Password = item.Password;

                _saveCustomerAndLoan();

                _newInfo();
                return RedirectToAction("Index", "LoanCPE");
            }
            else
            {
                return View(item);
            }
        }

        public ActionResult SelfConfirmWithLogin()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            return View();
        }
        [HttpPost]
        public ActionResult SelfConfirmWithLogin1()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");

            _saveLoanInfoAndLoanDetail();
            _newInfo();
            return RedirectToAction("Index", "LoanCPE");
        }
        public ActionResult SelfConfirm()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            return View();
        }
        [HttpPost]
        public ActionResult SelfConfirm(Register item)
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            if (ModelState.IsValid)
            {
                PublicClass._customerCur.UserName = item.UserName;
                PublicClass._customerCur.Password = item.Password;
                _saveCustomerAndLoan();
                _newInfo();
                return RedirectToAction("Index", "LoanCPE");
            }
            else
            {
                return View(item);
            }
        }
        public ActionResult Rental()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "LoanCPE");
            return View();
        }
        public JsonResult CheckUsername(string Username)
        {
            if (_DALCustomer.CheckCustomerByUsername(Username))
                return Json("true");
            else
                return Json("false");
        }
        public JsonResult SelfReturn(SelfReturn selfReturn, string PickDate, string ReturnDate)
        {
            try
            {
                PublicClass._selfReturn = selfReturn;
                PublicClass._loanInfo.Agent_Promotion_Code = selfReturn.PromotionCode;
                PublicClass._loanInfo.AgentCode = selfReturn.AgentCode;
                if (PickDate != "")
                    PublicClass._loanInfo.CollectionDate = DateTime.ParseExact(PickDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                //PublicClass._loanInfo.CollectionDate = selfReturn.PickDate;
                PublicClass._loanInfo.CollectionLocation = selfReturn.Location;
                PublicClass._loanInfo.Delivery = 0;
                PublicClass._loanInfo.DeviceQuantity = selfReturn.DeviceQTY;
                PublicClass._loanInfo.RentalMode = "Self-Collect & Return";
                if (ReturnDate != "")
                    PublicClass._loanInfo.ReturnDate = DateTime.ParseExact(ReturnDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                //PublicClass._loanInfo.ReturnDate = selfReturn.ReturnDate;
                PublicClass._delivery = null;
                return null;
            }
            catch { return null; }
        }
        public JsonResult Delivery(Delivery delivery, string DeliveryDate, string ReturnDate)
        {
            try
            {
                PublicClass._delivery = delivery;
                PublicClass._loanInfo.Agent_Promotion_Code = delivery.PromotionCode;
                PublicClass._loanInfo.AgentCode = delivery.AgentCode;
                if (DeliveryDate!="")
                PublicClass._loanInfo.CollectionDate = Convert.ToDateTime(DateTime.ParseExact(DeliveryDate, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToShortDateString() + " " + delivery.DeliveryTime + ":00:00.000");
                //PublicClass._loanInfo.CollectionDate =Convert.ToDateTime( delivery.DeliveryDate.ToShortDateString() + " " + delivery.DeliveryTime + ":00:00.000");
                PublicClass._loanInfo.CollectionLocation = 0;
                PublicClass._loanInfo.Delivery = 0;
                PublicClass._loanInfo.DeviceQuantity = delivery.DeviceQTY;
                PublicClass._loanInfo.RentalMode = "Delivery";
                if (ReturnDate != "")
                PublicClass._loanInfo.ReturnDate = Convert.ToDateTime(DateTime.ParseExact(ReturnDate, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToShortDateString() + " " + delivery.ReturnTime + ":00:00.000");
                //PublicClass._loanInfo.ReturnDate = Convert.ToDateTime(delivery.ReturnDate.ToShortDateString() + " " + delivery.ReturnTime + ":00:00.000"); 
                PublicClass._loanInfo.BookedName = delivery.BookedName;
                PublicClass._loanInfo.DeliveryAddress = delivery.DeliveryAddress;
                PublicClass._selfReturn = null;
                return null;
            }
            catch { return null; }
        }
	}
}