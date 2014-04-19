using System;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface ILoanDetailsDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.LoanDetail loandetail);
        System.Collections.Generic.List<Models.LoanDetail> SelectAll();
        Models.LoanDetail SelectByID(int ID);
        bool Update(Models.LoanDetail loandetailUpdate);
        System.Collections.Generic.List<Models.LoanDetail> SelectByLoanID(int LoanID);
        int GetMaxID();
    }
}
