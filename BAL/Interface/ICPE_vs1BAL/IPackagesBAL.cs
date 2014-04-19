using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface.ICPE_vs1BAL
{
    public interface IPackagesBAL
    {
        bool Insert(Models.Package package);
        bool Update(Models.Package packageUpdate);
        bool DeleteByID(int ID);
        List<Models.Package> SelectAll();
        Models.Package SelectByID(int ID);
        bool CheckByID(int ID);
    }
}

