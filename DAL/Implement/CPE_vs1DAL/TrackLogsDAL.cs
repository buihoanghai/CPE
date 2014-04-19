using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class TrackLogsDAL : DAL.Implement.CPE_vs1DAL.ITrackLogsDAL
    {
        public bool Insert(Models.TrackLog tracklog)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.TrackLogs.Add(tracklog);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.TrackLog tracklogUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.TrackLog tracklog = db.TrackLogs.Single<Models.TrackLog>(c => c.ID == tracklogUpdate.ID);
                    tracklog.Action = tracklogUpdate.Action;
		    tracklog.Type = tracklogUpdate.Type;
		    tracklog.TimeAction = tracklogUpdate.TimeAction;
		    tracklog.Staff_ID = tracklogUpdate.Staff_ID;
		    
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool DeleteByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try{
                    var tracklog = db.TrackLogs.Single(c => c.ID == ID);
                    db.TrackLogs.Remove(tracklog);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.TrackLog> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.TrackLogs.ToList();
                }
                catch { return null; }
            }
        }
        public Models.TrackLog SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.TrackLogs.Single(c => c.ID == ID);
                }
                catch { return null; }
            }
        }
        public bool CheckByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    db.TrackLogs.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }
    }
}

