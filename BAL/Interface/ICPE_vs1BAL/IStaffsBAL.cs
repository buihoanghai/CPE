using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface.ICPE_vs1BAL
{
    public interface IStaffsBAL
    {
        bool Insert(Models.Staff staff);
        bool Update(Models.Staff staffUpdate);
        bool DeleteByID(int ID);
        List<Models.Staff> SelectAll();
        Models.Staff SelectByID(int ID);
        bool CheckByID(int ID);
        List<Models.Staff> GetAllStaffNotAdmin();
    }
}

