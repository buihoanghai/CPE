using System;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface IPackagesDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.Package package);
        System.Collections.Generic.List<Models.Package> SelectAll();
        Models.Package SelectByID(int ID);
        bool Update(Models.Package packageUpdate);
    }
}
