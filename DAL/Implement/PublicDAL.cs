using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.Implement
{
    public class PublicDAL : IPublicDAL
    {
        public bool DeleteFromTableWhere(string table, string Where)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    string SQL = "delete from " + table;
                    if (Where.Length > 0)
                    {
                        SQL += " where " + Where;
                    }
                    db.Database.ExecuteSqlCommand(SQL);
                    //db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool UpdateColumnFromTableWhere(string table, string column, string Where)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    string SQL = "Update " + table + " set " + column;
                    if (Where.Length > 0)
                    {
                        SQL += " where " + Where;
                    }
                    db.Database.ExecuteSqlCommand(SQL);
                    //db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public string SelectValueFromTableWhereSQLQuery(string Condition, string Table, string Where)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {

                    string sql = "select count(*) from " + Table;
                    if (Condition.Length > 0)
                        sql = "select " + Condition + " from " + Table;
                    if (Where.Length > 0)
                        sql += " where " + Where;
                    var s = db.Database.SqlQuery<string>(sql).FirstOrDefault<string>();
                    return s;
                }
                catch { return ""; }
            }
        }


        public IEnumerable<Models.DeviceTransactions> getAllDeviceTransationsByLoanDate(DateTime dateFrom, DateTime dateTo)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                var DeviceTran = from ld in db.LoanDetails
                                 from l in db.Loans
                                 from cus in db.Customers
                                 from cpe in db.CPEs
                                 where ld.CPE_ID == cpe.ID && ld.Loan_ID == l.ID && l.Customer_ID == cus.ID &&
                                 dateFrom.Date <= ld.LoanDate && ld.LoanDate <= dateTo.Date
                                 select new Models.DeviceTransactions { Barcode = cpe.Barcode, SIMNo = cpe.SIMNo, Status = (int)ld.Status, SiteLoan_ID = (int)ld.SiteLoan_ID, Name = cus.Name, Passport = cus.Passport, DrivingLisence = cus.DrivingLisence, IDLisence = cus.IDLisence, LoanDate = (DateTime)ld.LoanDate };
                return DeviceTran.ToList<Models.DeviceTransactions>();
            }
        }


        public List<Models.SiteCPEStaff> GetAllSiteCpe()
        {
            using (var db = new Models.DBContextCPEDB())
            {
                var SiteCPE = from site in db.Sites
                              join cpe in db.CPEs on site.ID equals cpe.Site_ID into siteCpe
                              select new Models.SiteCPEStaff { ID = site.ID, SiteName = site.Name, CPEQuantity = siteCpe.Count() };
                return SiteCPE.ToList<Models.SiteCPEStaff>();
            }
        }

        public List<Models.SiteCPEStaff> GetAllSiteStaff()
        {
            using (var db = new Models.DBContextCPEDB())
            {
                var SiteCPE = from site in db.Sites
                              join staff in db.Staffs on site.ID equals staff.Site_ID into siteStaff
                              select new Models.SiteCPEStaff { ID = site.ID, SiteName = site.Name, StaffQuantity = siteStaff.Count() };
                return SiteCPE.ToList<Models.SiteCPEStaff>();
            }
        }
    }
}
