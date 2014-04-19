using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface.ICPE_vs1BAL
{
    public interface ICustomersBAL
    {
        bool Insert(Models.Customer customer);
        bool Update(Models.Customer customerUpdate);
        bool DeleteByID(int ID);
        List<Models.Customer> SelectAll();
        Models.Customer SelectByID(int ID);
        bool CheckByID(int ID);
    }
}

