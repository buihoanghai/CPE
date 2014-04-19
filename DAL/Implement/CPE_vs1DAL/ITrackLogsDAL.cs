using System;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface ITrackLogsDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.TrackLog tracklog);
        System.Collections.Generic.List<Models.TrackLog> SelectAll();
        Models.TrackLog SelectByID(int ID);
        bool Update(Models.TrackLog tracklogUpdate);
    }
}
