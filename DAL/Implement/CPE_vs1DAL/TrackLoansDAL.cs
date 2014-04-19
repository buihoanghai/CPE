using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class TrackLoansDAL : DAL.Implement.CPE_vs1DAL.ITrackLoansDAL
    {
        public bool Insert(Models.TrackLoan trackloan)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.TrackLoans.Add(trackloan);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.TrackLoan trackloanUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.TrackLoan trackloan = db.TrackLoans.Single<Models.TrackLoan>(c => c.ID == trackloanUpdate.ID);
                    trackloan.LoanDetail_ID = trackloanUpdate.LoanDetail_ID;
		    trackloan.Package_ID = trackloanUpdate.Package_ID;
		    trackloan.Type = trackloanUpdate.Type;
		    trackloan.Modified = trackloanUpdate.Modified;
		    trackloan.Modified_By = trackloanUpdate.Modified_By;
		    
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
                    var trackloan = db.TrackLoans.Single(c => c.ID == ID);
                    db.TrackLoans.Remove(trackloan);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.TrackLoan> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.TrackLoans.ToList();
                }
                catch { return null; }
            }
        }
        public Models.TrackLoan SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.TrackLoans.Single(c => c.ID == ID);
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
                    db.TrackLoans.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }


        public bool DeleteByLoanDetailID(int LoanDetailID)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    var trackloan = db.TrackLoans.Single(c => c.LoanDetail_ID == LoanDetailID);
                    db.TrackLoans.Remove(trackloan);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
    }
}

