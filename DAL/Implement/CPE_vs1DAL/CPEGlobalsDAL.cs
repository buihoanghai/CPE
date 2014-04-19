using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class CPEGlobalsDAL:ICPEGlobalsDAL
    {
        public bool Insert(Models.CPEGlobal cpeglobal)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.CPEGlobals.Add(cpeglobal);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.CPEGlobal cpeglobalUpdate)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    Models.CPEGlobal cpeglobal = db.CPEGlobals.Single<Models.CPEGlobal>(c => c.ID == cpeglobalUpdate.ID);
                    cpeglobal.Name = cpeglobalUpdate.Name;
		    cpeglobal.Price = cpeglobalUpdate.Price;
		    cpeglobal.Deposit = cpeglobalUpdate.Deposit;
		    cpeglobal.Description = cpeglobalUpdate.Description;
		    cpeglobal.Modified_By = cpeglobalUpdate.Modified_By;
		    cpeglobal.Modified = cpeglobalUpdate.Modified;
		    
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool DeleteByID(int ID)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try{
                    var cpeglobal = db.CPEGlobals.Single(c => c.ID == ID);
                    db.CPEGlobals.Remove(cpeglobal);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.CPEGlobal> SelectAll()
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.CPEGlobals.ToList();
                }
                catch { return null; }
            }
        }
        public Models.CPEGlobal SelectByID(int ID)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.CPEGlobals.Single(c => c.ID == ID);
                }
                catch { return null; }
            }
        }
        public bool CheckByID(int ID)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.CPEGlobals.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }
    }
}

