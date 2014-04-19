using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Interface.ICPE_vs1BAL;
using DAL.Implement.CPE_vs1DAL;

namespace BAL.Implement.CPE_vs1BAL
{
    public class StaffsBAL:IStaffsBAL
    {
        public IStaffsDAL IStaffDAL = new StaffsDAL();
        public bool Insert(Models.Staff staff)
        {
            return IStaffDAL.Insert(staff);
        }
        public bool Update(Models.Staff staffUpdate)
        {
            return IStaffDAL.Update(staffUpdate);
        }
        public bool DeleteByID(int ID)
        {
            return IStaffDAL.DeleteByID(ID);
        }
        public List<Models.Staff> SelectAll()
        {
            return IStaffDAL.SelectAll();
        }
        public Models.Staff SelectByID(int ID)
        {
            return IStaffDAL.SelectByID(ID);
        }
        public bool CheckByID(int ID)
        {
            return IStaffDAL.CheckByID(ID);
        }
        public List<Models.Staff> GetAllStaffNotAdmin()
        {
            return IStaffDAL.GetAllStaffNotAdmin();
        }
    }
}

