using System;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface ITrackLoansDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.TrackLoan trackloan);
        System.Collections.Generic.List<Models.TrackLoan> SelectAll();
        Models.TrackLoan SelectByID(int ID);
        bool Update(Models.TrackLoan trackloanUpdate);
        bool DeleteByLoanDetailID(int LoanDetailID);
    }
}
