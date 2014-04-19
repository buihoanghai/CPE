using System;
using System.Collections.Generic;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface ICPEsDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.CPE cpe);
        System.Collections.Generic.List<Models.CPE> ListBySiteID(int SiteID);
        System.Collections.Generic.List<Models.CPE> SelectAll();
        Models.CPE SelectByID(int ID);
        bool Update(Models.CPE cpeUpdate);
        Models.CPE SelectByBarcodeStatuNormal(string Barcode,int SiteID);
        List<Models.CPE> ListByCPENormalAndSiteID(int SiteID);
        List<Models.CPE> ListCPEbyCodeTransferOfToSite(string TransferCode,int ToSite);
        Models.CPE GetCPEByTransferToThisSite(string Barcode,int thisSite,string TransferCode);
        bool CheckExistBarcodeRented(string Barcode);
    }
}
