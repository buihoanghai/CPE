using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class CPEsDAL:ICPEsDAL
    {
        public bool Insert(Models.CPE cpe)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.CPEs.Add(cpe);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.CPE cpeUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.CPE cpe = db.CPEs.Single<Models.CPE>(c => c.ID == cpeUpdate.ID);
                    cpe.Barcode = cpeUpdate.Barcode;
                    cpe.Site_ID = cpeUpdate.Site_ID;
                    cpe.Status = cpeUpdate.Status;
                    cpe.Modified_By = cpeUpdate.Modified_By;
                    cpe.Modified = cpeUpdate.Modified;
                    cpe.CPECategory_ID = cpeUpdate.CPECategory_ID;
                    cpe.SIMNo = cpeUpdate.SIMNo;
                    cpe.ToSite = cpeUpdate.ToSite;
                    cpe.CodeTransfer = cpeUpdate.CodeTransfer;
                    cpe.FromSite = cpeUpdate.FromSite;
                    cpe.CheckOutDate = cpeUpdate.CheckOutDate;
                    cpe.CheckInDate = cpeUpdate.CheckInDate;
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
                    var cpe = db.CPEs.Single(c => c.ID == ID);
                    db.CPEs.Remove(cpe);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.CPE> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.CPEs.ToList();
                }
                catch { return null; }
            }
        }
        public Models.CPE SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.CPEs.Single(c => c.ID == ID);
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
                    db.CPEs.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }
        public List<Models.CPE> ListBySiteID(int SiteID)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                return db.CPEs.Where(c => c.Site_ID == SiteID).ToList();
            }
        }


        public Models.CPE SelectByBarcodeStatuNormal(string Barcode, int SiteID)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.CPEs.Single(c => c.Barcode == Barcode && c.Status==1 && c.Site_ID==SiteID);
                }
                catch { return null; }
            }
        }

        public List<Models.CPE> ListByCPENormalAndSiteID(int SiteID)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                return db.CPEs.Where(c => c.Site_ID == SiteID && c.Status==1).ToList();
            }
        }


        public List<Models.CPE> ListCPEbyCodeTransferOfToSite(string TransferCode,int ToSite)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                return db.CPEs.Where(c => c.CodeTransfer==TransferCode && c.ToSite==ToSite).ToList();
            }
        }


        public Models.CPE GetCPEByTransferToThisSite(string Barcode,int thisSite,string TransferCode)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                return db.CPEs.Where(c => c.Barcode == Barcode && c.ToSite == thisSite && c.CodeTransfer == TransferCode).First();
            }
        }


        public bool CheckExistBarcodeRented(string Barcode)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try 
                {
                    var cpe = db.CPEs.Single(c => c.Barcode == Barcode && c.Status == 5);
                    if (cpe != null && cpe.ID != 0)
                        return true;
                    return false;
                }
                catch { return false; }
                
            }
        }
    }
}

