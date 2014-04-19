using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class PenaltysDAL:IPenaltysDAL
    {
        public bool Insert(Models.Penalty penalty)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Penalties.Add(penalty);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.Penalty penaltyUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.Penalty penalty = db.Penalties.Single<Models.Penalty>(c => c.ID == penaltyUpdate.ID);
		    penalty.Title = penaltyUpdate.Title;
		    penalty.Amount = penaltyUpdate.Amount;
		    penalty.Percents = penaltyUpdate.Percents;
		    penalty.Modified = penaltyUpdate.Modified;
		    penalty.Modified_By = penaltyUpdate.Modified_By;
		    
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
                    var penalty = db.Penalties.Single(c => c.ID == ID);
                    db.Penalties.Remove(penalty);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.Penalty> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Penalties.ToList();
                }
                catch { return null; }
            }
        }
        public Models.Penalty SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Penalties.Single(c => c.ID == ID);
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
                    db.Penalties.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }
    }
}

