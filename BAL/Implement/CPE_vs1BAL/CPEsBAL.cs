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
    public class CPEsBAL:ICPEsBAL
    {
        public ICPEsDAL ICPEDAL = new CPEsDAL();
        public bool Insert(Models.CPE cpe)
        {
            return ICPEDAL.Insert(cpe);
        }
        public bool Update(Models.CPE cpeUpdate)
        {
            return ICPEDAL.Update(cpeUpdate);
        }
        public bool DeleteByID(int ID)
        {
            return ICPEDAL.DeleteByID(ID);
        }
        public List<Models.CPE> SelectAll()
        {
            return ICPEDAL.SelectAll();
        }
        public Models.CPE SelectByID(int ID)
        {
            return ICPEDAL.SelectByID(ID);
        }
        public bool CheckByID(int ID)
        {
            return ICPEDAL.CheckByID(ID);
        }
    }
}

