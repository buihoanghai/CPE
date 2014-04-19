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
    public class LoansBAL:ILoansBAL
    {
        public ILoansDAL ILoanDAL = new LoansDAL();
        public bool Insert(Models.Loan loan)
        {
            return ILoanDAL.Insert(loan);
        }
        public bool Update(Models.Loan loanUpdate)
        {
            return ILoanDAL.Update(loanUpdate);
        }
        public bool DeleteByID(int ID)
        {
            return ILoanDAL.DeleteByID(ID);
        }
        public List<Models.Loan> SelectAll()
        {
            return ILoanDAL.SelectAll();
        }
        public Models.Loan SelectByID(int ID)
        {
            return ILoanDAL.SelectByID(ID);
        }
        public bool CheckByID(int ID)
        {
            return ILoanDAL.CheckByID(ID);
        }
    }
}

