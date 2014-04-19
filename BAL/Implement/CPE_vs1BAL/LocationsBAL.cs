using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Interface.ICPE_vs1BAL;
using DAL.Implement.CPE_vs1DAL;

namespace BAL.Implement.CPE_vs1BAL
{
    public class LocationsBAL:ILocationsBAL
    {
        public ILocationsDAL ILocationDAL = new LocationsDAL();
        public bool Insert(Models.Location location)
        {
            return ILocationDAL.Insert(location);
        }
        public bool Update(Models.Location locationUpdate)
        {
            return ILocationDAL.Update(locationUpdate);
        }
        public bool DeleteByID(int ID)
        {
            return ILocationDAL.DeleteByID(ID);
        }
        public List<Models.Location> SelectAll()
        {
            return ILocationDAL.SelectAll();
        }
        public Models.Location SelectByID(int ID)
        {
            return ILocationDAL.SelectByID(ID);
        }
        public bool CheckByID(int ID)
        {
            return ILocationDAL.CheckByID(ID);
        }
    }
}

