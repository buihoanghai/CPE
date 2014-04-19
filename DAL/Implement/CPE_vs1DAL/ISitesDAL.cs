using System;
using System.Collections.Generic;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface ISitesDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.Site site);
        System.Collections.Generic.List<Models.Site> SelectAll();
        Models.Site SelectByID(int ID);
        bool Update(Models.Site siteUpdate);
        List<Models.Site> SelectAllExcludeThisSite(int thisSite);
        bool CheckHaveSite(int siteID);
    }
}
