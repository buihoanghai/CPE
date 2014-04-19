using System;
namespace DAL.Implement.CPE_vs1DAL
{
    interface IPenaltysDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.Penalty penalty);
        System.Collections.Generic.List<Models.Penalty> SelectAll();
        Models.Penalty SelectByID(int ID);
        bool Update(Models.Penalty penaltyUpdate);
    }
}
