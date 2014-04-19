using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class PackagesDAL:IPackagesDAL
    {
        public bool Insert(Models.Package package)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Packages.Add(package);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.Package packageUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.Package package = db.Packages.Single<Models.Package>(c => c.ID == packageUpdate.ID);
		    package.Days = packageUpdate.Days;
		    package.Name = packageUpdate.Name;
		    package.EOM = packageUpdate.EOM;
		    package.Price = packageUpdate.Price;
		    package.Modified = packageUpdate.Modified;
		    package.Modified_By = packageUpdate.Modified_By;
		    
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
                    var package = db.Packages.Single(c => c.ID == ID);
                    db.Packages.Remove(package);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.Package> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Packages.ToList();
                }
                catch { return null; }
            }
        }
        public Models.Package SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Packages.Single(c => c.ID == ID);
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
                    db.Packages.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }
    }
}

