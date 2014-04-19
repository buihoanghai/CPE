using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class LoansDAL:ILoansDAL
    {
        public bool Insert(Models.Loan loan)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Loans.Add(loan);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.Loan loanUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.Loan loan = db.Loans.Single<Models.Loan>(c => c.ID == loanUpdate.ID);
                    loan.Customer_ID = loanUpdate.Customer_ID;
                    loan.Staff_ID = loanUpdate.Staff_ID;
                    loan.Status = loanUpdate.Status;
                    loan.Modified_By = loanUpdate.Modified_By;
                    loan.Modified = loanUpdate.Modified;
                    loan.CustomerCode = loanUpdate.CustomerCode;
                    loan.CustomerBarcode = loanUpdate.CustomerBarcode;
                    loan.ReturnType = loanUpdate.ReturnType;
                    loan.LoanSiteID = loanUpdate.LoanSiteID;
                    loan.Delivery = loanUpdate.Delivery;
                    loan.DeliveryAddress = loanUpdate.DeliveryAddress;
                    loan.RentalPrice = loanUpdate.RentalPrice;
                    loan.OnlineDiscount = loanUpdate.OnlineDiscount;
                    loan.OnlineDiscountCode = loanUpdate.OnlineDiscountCode;
                    loan.SubTotal = loanUpdate.SubTotal;
                    loan.CreditCardNumer = loanUpdate.CreditCardNumer;
                    loan.ExpiredateCreditCard = loanUpdate.ExpiredateCreditCard;
                    loan.NameOnCard = loanUpdate.NameOnCard;
                    loan.BookedName = loanUpdate.BookedName;
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool DeleteByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try{
                    var loan = db.Loans.Single(c => c.ID == ID);
                    db.Loans.Remove(loan);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.Loan> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Loans.Include("LoanDetails").ToList();
                }
                catch { return null; }
            }
        }
        public Models.Loan SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Loans.Include("LoanDetails").Single(c => c.ID == ID);
                }
                catch { return null; }
            }
        }
        public bool CheckByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    db.Loans.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }


        public Models.Loan SelectByCustomerCode(string customerCode)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Loans.Include("LoanDetails").Single(c => c.CustomerCode == customerCode);
                }
                catch { return null; }
            }
        }


        public Models.Loan GetLoanByBarcode(string barcode)
        {
            try
            {
                using (var db = new Models.DBContextCPEDB())
                {
                    var Loan = from ld in db.LoanDetails
                               from l in db.Loans
                               from cpe in db.CPEs
                               where ld.CPE_ID == cpe.ID && ld.Loan_ID == l.ID &&
                               cpe.Barcode == barcode
                               select l;
                    return Loan.First<Models.Loan>();
                }
            }
            catch { return null; }
        }
        public int GetMaxID()
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Loans.Max(c => c.ID);
                }
                catch { return 0; }
            }
        }
    }
}

