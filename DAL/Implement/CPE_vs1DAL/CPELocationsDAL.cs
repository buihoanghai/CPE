using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class CPELocationsDAL:ICPELocationsDAL
    {
        public bool Insert(Models.CPELocation cpelocation)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.CPELocations.Add(cpelocation);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.CPELocation cpelocationUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.CPELocation cpelocation = db.CPELocations.Single<Models.CPELocation>(c => c.ID == cpelocationUpdate.ID);
                    cpelocation.CPE_ID = cpelocationUpdate.CPE_ID;
		    cpelocation.Location_ID = cpelocationUpdate.Location_ID;
		    cpelocation.Amount = cpelocationUpdate.Amount;
		    cpelocation.Modified = cpelocationUpdate.Modified;
		    cpelocation.Modified_By = cpelocationUpdate.Modified_By;
		    
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
                    var cpelocation = db.CPELocations.Single(c => c.ID == ID);
                    db.CPELocations.Remove(cpelocation);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.CPELocation> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.CPELocations.ToList();
                }
                catch { return null; }
            }
        }
        public Models.CPELocation SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.CPELocations.Single(c => c.ID == ID);
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
                    db.CPELocations.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }
    }
}

