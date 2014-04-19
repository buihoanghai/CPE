using System;
namespace DAL.Implement.CPE_vs1DAL
{
    interface ICPELocationsDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.CPELocation cpelocation);
        System.Collections.Generic.List<Models.CPELocation> SelectAll();
        Models.CPELocation SelectByID(int ID);
        bool Update(Models.CPELocation cpelocationUpdate);
    }
}
