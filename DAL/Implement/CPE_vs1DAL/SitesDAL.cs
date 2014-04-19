using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class SitesDAL:ISitesDAL
    {
        public bool Insert(Models.Site site)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Sites.Add(site);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.Site siteUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.Site site = db.Sites.Single<Models.Site>(c => c.ID == siteUpdate.ID);
                    site.Name = siteUpdate.Name;
		    site.Amount = siteUpdate.Amount;
		    site.Modified_By = siteUpdate.Modified_By;
		    site.Modified = siteUpdate.Modified;
		    
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
                    var site = db.Sites.Single(c => c.ID == ID);
                    db.Sites.Remove(site);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.Site> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Sites.ToList();
                }
                catch { return null; }
            }
        }
        public Models.Site SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Sites.Single(c => c.ID == ID);
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
                    db.Sites.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }


        public List<Models.Site> SelectAllExcludeThisSite(int thisSite)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Sites.Where(s=>s.ID != thisSite).ToList();
                }
                catch { return null; }
            }
        }


        public bool CheckHaveSite(int siteID)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    var site = from s in db.Sites
                               from st in db.Staffs.Where(sta=>sta.Site_ID==s.ID).DefaultIfEmpty()
                               from ld in db.LoanDetails.Where(lde=>lde.SiteLoan_ID==s.ID).DefaultIfEmpty()
                               from l in db.Loans.Where(lo=>lo.LoanSiteID== s.ID).DefaultIfEmpty()
                               from cpe in db.CPEs.Where(cp=>cp.Site_ID==s.ID).DefaultIfEmpty()
                               where st.Site_ID==siteID || ld.SiteLoan_ID==siteID || l.LoanSiteID==siteID || cpe.Site_ID==siteID
                               select s;
                    if ((int)site.Count() > 0)
                        return true;
                    else
                        return false;
                }
                catch { return true; }
            }
        }
    }
}

