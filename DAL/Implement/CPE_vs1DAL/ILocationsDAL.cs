using System;
namespace DAL.Implement.CPE_vs1DAL
{
    interface ILocationsDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.Location location);
        System.Collections.Generic.List<Models.Location> SelectAll();
        Models.Location SelectByID(int ID);
        bool Update(Models.Location locationUpdate);
    }
}
