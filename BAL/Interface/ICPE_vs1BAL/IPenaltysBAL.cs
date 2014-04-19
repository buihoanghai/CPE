using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface.ICPE_vs1BAL
{
    public interface IPenaltysBAL
    {
        bool Insert(Models.Penalty penalty);
        bool Update(Models.Penalty penaltyUpdate);
        bool DeleteByID(int ID);
        List<Models.Penalty> SelectAll();
        Models.Penalty SelectByID(int ID);
        bool CheckByID(int ID);
    }
}

