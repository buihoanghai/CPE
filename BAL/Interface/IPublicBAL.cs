using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface
{
    public interface IPublicBAL
    {
        bool DeleteFromTableWhere(string table, string Where);
        bool UpdateColumnFromTableWhere(string table, string column, string Where);
        string SelectValueFromTableWhereSQLQuery(string Condition, string Table, string Where);
    }
}

