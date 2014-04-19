using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface.ICPE_vs1BAL
{
    public interface ICPELocationsBAL
    {
        bool Insert(Models.CPELocation cpelocation);
        bool Update(Models.CPELocation cpelocationUpdate);
        bool DeleteByID(int ID);
        List<Models.CPELocation> SelectAll();
        Models.CPELocation SelectByID(int ID);
        bool CheckByID(int ID);
    }
}

