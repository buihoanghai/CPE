using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface.ICPE_vs1BAL
{
    public interface ILoansBAL
    {
        bool Insert(Models.Loan loan);
        bool Update(Models.Loan loanUpdate);
        bool DeleteByID(int ID);
        List<Models.Loan> SelectAll();
        Models.Loan SelectByID(int ID);
        bool CheckByID(int ID);
    }
}

