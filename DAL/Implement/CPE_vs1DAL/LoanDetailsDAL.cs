using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class LoanDetailsDAL:ILoanDetailsDAL
    {
        public bool Insert(Models.LoanDetail loandetail)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.LoanDetails.Add(loandetail);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.LoanDetail loandetailUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.LoanDetail loandetail = db.LoanDetails.Single<Models.LoanDetail>(c => c.ID == loandetailUpdate.ID);
                    loandetail.Loan_ID = loandetailUpdate.Loan_ID;
                    loandetail.RentDay = loandetailUpdate.RentDay;
                    loandetail.PenaltyAmount = loandetailUpdate.PenaltyAmount;
                    loandetail.LoanDate = loandetailUpdate.LoanDate;
                    loandetail.ReturnDate = loandetailUpdate.ReturnDate;
                    loandetail.RentAmount = loandetailUpdate.RentAmount;
                    loandetail.Deposit = loandetailUpdate.Deposit;
                    loandetail.SiteLoan_ID = loandetailUpdate.SiteLoan_ID;
                    loandetail.SiteReturn_ID = loandetailUpdate.SiteReturn_ID;
                    loandetail.Status = loandetailUpdate.Status;
                    loandetail.Modified_By = loandetailUpdate.Modified_By;
                    loandetail.Modified = loandetailUpdate.Modified;
                    loandetail.CPE_ID = loandetailUpdate.CPE_ID;
                    loandetail.PromotionDisCount = loandetailUpdate.PromotionDisCount;
                    loandetail.AgentCode = loandetailUpdate.AgentCode;
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
                    var loandetail = db.LoanDetails.Single(c => c.ID == ID);
                    db.LoanDetails.Remove(loandetail);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.LoanDetail> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.LoanDetails.ToList();
                }
                catch { return null; }
            }
        }
        public Models.LoanDetail SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.LoanDetails.Single(c => c.ID == ID);
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
                    db.LoanDetails.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }



        public List<Models.LoanDetail> SelectByLoanID(int LoanID)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.LoanDetails.Where(l => l.Loan_ID == LoanID).ToList();
                }
                catch { return null; }
            }
        }

        public int GetMaxID()
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.LoanDetails.Max(l => l.ID);
                }
                catch { return 0; }
            }
        }
    }
}

