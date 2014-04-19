using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface.ICPE_vs1BAL
{
    public interface ILoanDetailsBAL
    {
        bool Insert(Models.LoanDetail loandetail);
        bool Update(Models.LoanDetail loandetailUpdate);
        bool DeleteByID(int ID);
        List<Models.LoanDetail> SelectAll();
        Models.LoanDetail SelectByID(int ID);
        bool CheckByID(int ID);
    }
}

