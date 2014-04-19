using System;
using System.Collections.Generic;
namespace DAL.Implement
{
     public interface IPublicDAL
    {
        bool DeleteFromTableWhere(string table, string Where);
        string SelectValueFromTableWhereSQLQuery(string Condition, string Table, string Where);
        bool UpdateColumnFromTableWhere(string table, string column, string Where);
        IEnumerable<Models.DeviceTransactions> getAllDeviceTransationsByLoanDate(DateTime from, DateTime To);
        List<Models.SiteCPEStaff> GetAllSiteCpe();
        List<Models.SiteCPEStaff> GetAllSiteStaff();
    }
}
