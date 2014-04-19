using DAL.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Interface;

namespace BAL.Implement
{
    public class PublicBAL : IPublicBAL
    {
        IPublicDAL IPublic = new PublicDAL();
        public bool DeleteFromTableWhere(string table, string Where)
        {
            return IPublic.DeleteFromTableWhere(table, Where);
        }
        public bool UpdateColumnFromTableWhere(string table, string column, string Where)
        {
            return IPublic.UpdateColumnFromTableWhere(table, column, Where);
        }
        public string SelectValueFromTableWhereSQLQuery(string Condition, string Table, string Where)
        {
            return IPublic.SelectValueFromTableWhereSQLQuery(Condition, Table, Where);
        }
    }
}
