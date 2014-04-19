using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Interface.ICPE_vs1BAL;
using DAL.Interface.ICPE_vs1DAL;
using DAL.Implement.CPE_vs1DAL;

namespace BAL.Implement.CPE_vs1BAL
{
    public class CPELocationsBAL:ICPELocationsBAL
    {
        public ICPELocationsDAL ICPELocationDAL = new CPELocationsDAL();
        public bool Insert(Models.CPELocation cpelocation)
        {
            return ICPELocationDAL.Insert(cpelocation);
        }
        public bool Update(Models.CPELocation cpelocationUpdate)
        {
            return ICPELocationDAL.Update(cpelocationUpdate);
        }
        public bool DeleteByID(int ID)
        {
            return ICPELocationDAL.DeleteByID(ID);
        }
        public List<Models.CPELocation> SelectAll()
        {
            return ICPELocationDAL.SelectAll();
        }
        public Models.CPELocation SelectByID(int ID)
        {
            return ICPELocationDAL.SelectByID(ID);
        }
        public bool CheckByID(int ID)
        {
            return ICPELocationDAL.CheckByID(ID);
        }
    }
}

