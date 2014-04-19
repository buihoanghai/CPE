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
    public class LoanDetailsBAL:ILoanDetailsBAL
    {
        public ILoanDetailsDAL ILoanDetailDAL = new LoanDetailsDAL();
        public bool Insert(Models.LoanDetail loandetail)
        {
            return ILoanDetailDAL.Insert(loandetail);
        }
        public bool Update(Models.LoanDetail loandetailUpdate)
        {
            return ILoanDetailDAL.Update(loandetailUpdate);
        }
        public bool DeleteByID(int ID)
        {
            return ILoanDetailDAL.DeleteByID(ID);
        }
        public List<Models.LoanDetail> SelectAll()
        {
            return ILoanDetailDAL.SelectAll();
        }
        public Models.LoanDetail SelectByID(int ID)
        {
            return ILoanDetailDAL.SelectByID(ID);
        }
        public bool CheckByID(int ID)
        {
            return ILoanDetailDAL.CheckByID(ID);
        }
    }
}

