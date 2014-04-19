using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace CPEWeb.Class
{
    public class PublicClass
    {
        public static LoanInfo _loanInfo = new LoanInfo();
        public static CustomerInfo _customerCur = new CustomerInfo();
        public static Loan _LoanCur = new Loan();
        public static SelfReturn _selfReturn = null;
        public static Delivery _delivery = null;
        public static Customer _convertCustomerInfoToCustomer(CustomerInfo cusInfo)
        {
            Customer cus=new Customer();
            cus.Address = cusInfo.Address;
            cus.Created = cusInfo.Created;
            cus.Created_By = cusInfo.Created_By;
            cus.DOB = cusInfo.DOB;
            cus.DrivingLisence = cusInfo.DrivingLisence;
            cus.Email = cusInfo.Email;
            cus.Expiry_date = cusInfo.Expiry_date;
            cus.ID = cusInfo.ID;
            cus.IDLisence = cusInfo.IDLisence;
            cus.Modified = cusInfo.Modified;
            cus.Modified_By = cusInfo.Modified_By;
            cus.Name = cusInfo.Name;
            cus.Nationality = cusInfo.Nationality;
            cus.Passport = cusInfo.Passport;
            cus.Password = cusInfo.Password;
            cus.Phone = cusInfo.Phone;
            cus.UserName = cusInfo.UserName;
            return cus;
        }
        public static CustomerInfo _convertCustomerToCustomerInfo(Customer cus)
        {
            CustomerInfo cusInfo = new CustomerInfo();
            cusInfo.Address = cus.Address;
            cusInfo.Created = cus.Created;
            cusInfo.Created_By = cus.Created_By;
            cusInfo.DOB = cus.DOB;
            cusInfo.DrivingLisence = cus.DrivingLisence;
            cusInfo.Email = cus.Email;
            cusInfo.Expiry_date = cus.Expiry_date;
            cusInfo.ID = cus.ID;
            cusInfo.IDLisence = cus.IDLisence;
            cusInfo.Modified = cus.Modified;
            cusInfo.Modified_By = cus.Modified_By;
            cusInfo.Name = cus.Name;
            cusInfo.Nationality = cus.Nationality;
            cusInfo.Passport = cus.Passport;
            cusInfo.Password = cus.Password;
            cusInfo.Phone = cus.Phone;
            cusInfo.UserName = cus.UserName;
            return cusInfo;
        }
    }
}