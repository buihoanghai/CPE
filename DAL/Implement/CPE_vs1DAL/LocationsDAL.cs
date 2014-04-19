using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class LocationsDAL:ILocationsDAL
    {
        public bool Insert(Models.Location location)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Locations.Add(location);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.Location locationUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.Location location = db.Locations.Single<Models.Location>(c => c.ID == locationUpdate.ID);
                    location.Site_ID = locationUpdate.Site_ID;
		    location.Name = locationUpdate.Name;
		    location.Address = locationUpdate.Address;
		    location.Modified = locationUpdate.Modified;
		    location.Modified_By = locationUpdate.Modified_By;
		    
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
                    var location = db.Locations.Single(c => c.ID == ID);
                    db.Locations.Remove(location);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.Location> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Locations.ToList();
                }
                catch { return null; }
            }
        }
        public Models.Location SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Locations.Single(c => c.ID == ID);
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
                    db.Locations.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }
    }
}

