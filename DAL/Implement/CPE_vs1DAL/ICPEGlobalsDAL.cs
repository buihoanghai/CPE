using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public interface ICPEGlobalsDAL
    {
        bool Insert(Models.CPEGlobal cpeglobal);
        bool Update(Models.CPEGlobal cpeglobalUpdate);
        bool DeleteByID(int ID);
        List<Models.CPEGlobal> SelectAll();
        Models.CPEGlobal SelectByID(int ID);
        bool CheckByID(int ID);

    }
}

