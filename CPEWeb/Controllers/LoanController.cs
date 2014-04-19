using CPEWeb.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using DAL.Implement.CPE_vs1DAL;
using System.IO;

namespace CPEWeb.Controllers
{
    public class LoanController : Controller
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
        private static void _newInfo()
        {
            PublicClass._customerCur = new CustomerInfo();
            PublicClass._loanInfo = new LoanInfo();
            PublicClass._LoanCur = new Loan();
            PublicClass._delivery = null;
            PublicClass._selfReturn = null;
        }
        void _saveLoanInfoAndLoanDetail()
        {
            
            _saveLoanInfo();
            _saveLoanDetail();
        }
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
        private void _saveLoanDetail()
        {
            bool flag = false;
            LoanDetail ld=new LoanDetail();
            for (int i = 0; i < PublicClass._loanInfo.DeviceQuantity; i++)
            {
                if (!flag)
                {
                    ld.Created = DateTime.Now.Date;
                    ld.Deposit = _DALCPEGlobal.SelectByID(1).Deposit;
                    ld.Loan_ID = PublicClass._LoanCur.ID;
                    ld.LoanDate = PublicClass._loanInfo.CollectionDate;
                    Promotion pro=_DALPromotion.SelectByPromotionCode(PublicClass._loanInfo.Agent_Promotion_Code);
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
                    flag=true;
                }
                if(flag)
                    _DALLoanDetail.Insert(ld);
            }
        }
        void _saveCustomer()
        {
            PublicClass._customerCur.Created = DateTime.Now.Date;
            Customer cus = PublicClass._convertCustomerInfoToCustomer( PublicClass._customerCur);
            _DALCustomer.Insert(cus);
            PublicClass._customerCur.ID = _DALCustomer.GetMaxID();
        }
        void _saveLoanInfo()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "").ToUpper();
            Loan l = new Loan();
            l.Created = DateTime.Now.Date;
            l.CreditCardNumer = PublicClass._loanInfo.CreditCard;
            l.Customer_ID = PublicClass._customerCur.ID;
            l.CustomerCode = path;
            l.Delivery = PublicClass._loanInfo.Delivery;
            l.LoanSiteID = PublicClass._loanInfo.CollectionLocation;
            l.OnlineDiscount = PublicClass._loanInfo.OnlineDiscount;
            l.OnlineDiscountCode = PublicClass._loanInfo.Agent_Promotion_Code;
            l.RentalPrice = PublicClass._loanInfo.RentalPrice;
            l.ReturnType = PublicClass._loanInfo.RentalMode;
            l.Status = 1;
            l.SubTotal = PublicClass._loanInfo.Total;
            _DALLoan.Insert(l);
            PublicClass._LoanCur = l;
            PublicClass._LoanCur.ID = _DALLoan.GetMaxID();
        }
        private void CalLoanAndSaveLoan()
        {
            if (PublicClass._LoanCur.ID == 0)
            {
                _checkAndcalcuLoan(PublicClass._loanInfo);
                _saveLoanInfoAndLoanDetail();
            }
        }
        #endregion
        //
        // GET: /Loan/

        public ActionResult Index()
        {
                return View();
        }
        public ActionResult InnerCustomer()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "Loan");
            _checkAndcalcuLoan(PublicClass._loanInfo);
            return View();
        }
        [HttpPost]
        public ActionResult InnerCustomer(CustomerInfo item)
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "Loan");
            if (ModelState.IsValid)
            {
                if (item.DrivingLisence == "Passport")
                    item.DrivingLisence = null;
                else if (item.DrivingLisence == "DrivingLisence")
                {
                    item.DrivingLisence = item.Passport;
                    item.Passport = null;
                    item.Expiry_date = null;

                }else
                {
                    item.IDLisence = item.Passport;
                    item.DrivingLisence = null;
                    item.Passport = null;
                    item.Expiry_date = null;

                }
                PublicClass._customerCur = item;
                _saveCustomer();
                _saveLoanInfoAndLoanDetail();
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
                return RedirectToAction("Index", "Loan");
            CalLoanAndSaveLoan();
            return View(new CreditCard());
        }
        [HttpPost]
        public ActionResult DeliveryPayment(CreditCard item)
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "Loan");
            if(ModelState.IsValid)
            {
                PublicClass._LoanCur.NameOnCard = item.NameOnCard;
                PublicClass._LoanCur.CreditCardNumer = item.CardNumber;
                PublicClass._LoanCur.ExpiredateCreditCard = item.ExpireDate;
                _DALLoan.Update(PublicClass._LoanCur);
                return RedirectToAction("DeliveryConfirm");
            }
            else
            {
                return View(item);
            }
        }
        public ActionResult SelfPayment()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "Loan");
            CalLoanAndSaveLoan();
            return View();
        }

        
        public ActionResult DeliveryConfirm()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "Loan");
            return View(new Register());
        }
        [HttpPost]
        public ActionResult DeliveryConfirm(Register item)
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "Loan");
            if (ModelState.IsValid)
            {
                PublicClass._customerCur.UserName = item.UserName;
                PublicClass._customerCur.Password = item.Password;
                _DALCustomer.Update(PublicClass._convertCustomerInfoToCustomer(PublicClass._customerCur));
                _newInfo();
                return RedirectToAction("Index","Loan");
            }
            else
            {
                return View(item);
            }
        }
        public ActionResult SelfConfirm()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "Loan");
            return View();
        }
        [HttpPost]
        public ActionResult SelfConfirm(Register item)
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "Loan");
            if (ModelState.IsValid)
            {
                PublicClass._customerCur.UserName = item.UserName;
                PublicClass._customerCur.Password = item.Password;
                _DALCustomer.Update(PublicClass._convertCustomerInfoToCustomer(PublicClass._customerCur));
                _newInfo();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(item);
            }
        }
        public ActionResult Rental()
        {
            if (PublicClass._delivery == null && PublicClass._selfReturn == null)
                return RedirectToAction("Index", "Loan");
            return View();
        }
        public JsonResult CheckUsername(string Username)
        {
            if (_DALCustomer.CheckCustomerByUsername(Username))
                return Json("true");
            else
                return Json("false");
        }

        //public JsonResult SelfReturn(int DeviceQTY, string Location, DateTime PickDate, DateTime ReturnDate, string PromotionCode, string AgentCode)
        //{
        //    if (true)
        //        return Json("true");
        //    else
        //        return Json("false");
        //}
        public JsonResult SelfReturn(SelfReturn selfReturn)
        {
            PublicClass._selfReturn = selfReturn;
            PublicClass._loanInfo.Agent_Promotion_Code = selfReturn.PromotionCode;
            PublicClass._loanInfo.AgentCode = selfReturn.AgentCode;
            PublicClass._loanInfo.CollectionDate = selfReturn.PickDate;
            PublicClass._loanInfo.CollectionLocation = selfReturn.Location;
            PublicClass._loanInfo.Delivery = 0;
            PublicClass._loanInfo.DeviceQuantity = selfReturn.DeviceQTY;
            PublicClass._loanInfo.RentalMode = "Self-Collect & Return";
            PublicClass._loanInfo.ReturnDate = selfReturn.ReturnDate;
            PublicClass._delivery = null;
                return null;
        }
        public JsonResult Delivery(Delivery delivery)
        {
            PublicClass._delivery = delivery;
            PublicClass._loanInfo.Agent_Promotion_Code = delivery.PromotionCode;
            PublicClass._loanInfo.AgentCode = delivery.AgentCode;
            PublicClass._loanInfo.CollectionDate = delivery.DeliveryDate;
            PublicClass._loanInfo.CollectionLocation = 0;
            PublicClass._loanInfo.Delivery = 0;
            PublicClass._loanInfo.DeviceQuantity = delivery.DeviceQTY;
            PublicClass._loanInfo.RentalMode = "Delivery";
            PublicClass._loanInfo.ReturnDate = delivery.ReturnDate;
            PublicClass._loanInfo.BookedName = delivery.BookedName;
            PublicClass._selfReturn = null;
            return null;
        }
	}
}