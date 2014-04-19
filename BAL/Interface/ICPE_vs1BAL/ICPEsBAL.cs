using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface.ICPE_vs1BAL
{
    public interface ICPEsBAL
    {
        bool Insert(Models.CPE cpe);
        bool Update(Models.CPE cpeUpdate);
        bool DeleteByID(int ID);
        List<Models.CPE> SelectAll();
        Models.CPE SelectByID(int ID);
        bool CheckByID(int ID);
    }
}

