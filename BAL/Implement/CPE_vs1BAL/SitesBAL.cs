using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Interface.ICPE_vs1BAL;
using DAL.Implement.CPE_vs1DAL;

namespace BAL.Implement.CPE_vs1BAL
{
    public class SitesBAL:ISitesBAL
    {
        public ISitesDAL ISiteDAL = new SitesDAL();
        public bool Insert(Models.Site site)
        {
            return ISiteDAL.Insert(site);
        }
        public bool Update(Models.Site siteUpdate)
        {
            return ISiteDAL.Update(siteUpdate);
        }
        public bool DeleteByID(int ID)
        {
            return ISiteDAL.DeleteByID(ID);
        }
        public List<Models.Site> SelectAll()
        {
            return ISiteDAL.SelectAll();
        }
        public Models.Site SelectByID(int ID)
        {
            return ISiteDAL.SelectByID(ID);
        }
        public bool CheckByID(int ID)
        {
            return ISiteDAL.CheckByID(ID);
        }
    }
}

