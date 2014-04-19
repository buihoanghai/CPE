using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface.ICPE_vs1BAL
{
    public interface ISitesBAL
    {
        bool Insert(Models.Site site);
        bool Update(Models.Site siteUpdate);
        bool DeleteByID(int ID);
        List<Models.Site> SelectAll();
        Models.Site SelectByID(int ID);
        bool CheckByID(int ID);
    }
}

