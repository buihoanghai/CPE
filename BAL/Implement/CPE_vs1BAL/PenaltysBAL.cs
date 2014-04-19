using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Interface.ICPE_vs1BAL;
using DAL.Implement.CPE_vs1DAL;

namespace BAL.Implement.CPE_vs1BAL
{
    public class PenaltysBAL:IPenaltysBAL
    {
        public IPenaltysDAL IPenaltyDAL = new PenaltysDAL();
        public bool Insert(Models.Penalty penalty)
        {
            return IPenaltyDAL.Insert(penalty);
        }
        public bool Update(Models.Penalty penaltyUpdate)
        {
            return IPenaltyDAL.Update(penaltyUpdate);
        }
        public bool DeleteByID(int ID)
        {
            return IPenaltyDAL.DeleteByID(ID);
        }
        public List<Models.Penalty> SelectAll()
        {
            return IPenaltyDAL.SelectAll();
        }
        public Models.Penalty SelectByID(int ID)
        {
            return IPenaltyDAL.SelectByID(ID);
        }
        public bool CheckByID(int ID)
        {
            return IPenaltyDAL.CheckByID(ID);
        }
    }
}

