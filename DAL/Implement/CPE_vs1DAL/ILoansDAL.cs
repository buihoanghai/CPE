using System;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface ILoansDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.Loan loan);
        System.Collections.Generic.List<Models.Loan> SelectAll();
        Models.Loan SelectByID(int ID);
        bool Update(Models.Loan loanUpdate);
        Models.Loan SelectByCustomerCode(string customerCode);
        Models.Loan GetLoanByBarcode(string barcode);
        int GetMaxID();
    }
}
