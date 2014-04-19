using CPEWeb.Class;
using DAL.Implement.CPE_vs1DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using System.Web.Security;

namespace CPEWeb.Controllers
{
    public class HomeController : Controller
    {
        #region variable

        ICustomersDAL _DALCustomer = new CustomersDAL();
        IPackagesDAL _DALPackage = new PackagesDAL();
        IPromotionsDAL _DALPromotion = new PromotionsDAL();

        #endregion

        #region method
        float _checkCountRent(LoanInfo loaninf)
        {
            try
            {


                int dayRent = (Convert.ToDateTime(loaninf.ReturnDate) - Convert.ToDateTime(loaninf.CollectionDate)).Days;

                float rentAmount = 0;
                var package=_DALPackage.SelectAll();
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
        private string _customerLogIn(string Username, string Password)
        {
            string data = "";
            Customer cus=_DALCustomer.Login(Username, Password);
            PublicClass._customerCur = cus==null?null: PublicClass._convertCustomerToCustomerInfo(cus);
            if (PublicClass._customerCur != null && PublicClass._customerCur.ID != 0)
                data = "Success";
            else
            {
                data = "Wrong Username or Password!";
            }
            return data;
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
        private static void _newInfo()
        {
            PublicClass._customerCur = new CustomerInfo();
            PublicClass._loanInfo = new LoanInfo();
            PublicClass._LoanCur = new Loan();
        }

        #endregion
        public ActionResult Edit()
        {
            return View(PublicClass._loanInfo);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            _newInfo();
            return RedirectToAction("Index","Home");
        }

        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
                return RedirectToAction("InnerCustomer", "Loan");

            _newInfo();
            return View(new LoanInfo());
        }
        
        [HttpPost]
        public ActionResult Index(LoanInfo item)
        {
            if (ModelState.IsValid)
            {
                _checkAndcalcuLoan(item);
                return RedirectToAction("InnerCustomer", "Loan");
            }
            else
            {
                return View(item);
            }
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            var data = _customerLogIn(Username,Password);
            if (data == "Success")
            {
                FormsAuthentication.SetAuthCookie(Username, false);
                if(PublicClass._selfReturn!=null)
                    return Json("Self");
                else
                    return Json("Delivery");
            }
            else
                return Json("Fail");
        }

        

    }
}