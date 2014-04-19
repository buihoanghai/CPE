using System;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface IStaffsDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        System.Collections.Generic.List<Models.Staff> GetAllStaffNotAdmin();
        bool Insert(Models.Staff staff);
        System.Collections.Generic.List<Models.Staff> SelectAll();
        Models.Staff SelectByID(int ID);
        bool Update(Models.Staff staffUpdate);
        bool CheckStaffByUsername(string UserName);
    }
}
