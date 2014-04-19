using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Interface.ICPE_vs1BAL;
using DAL.Interface.ICPE_vs1DAL;
using DAL.Implement.CPE_vs1DAL;

namespace BAL.Implement.CPE_vs1BAL
{
    public class CustomersBAL:ICustomersBAL
    {
        public ICustomersDAL ICustomerDAL = new CustomersDAL();
        public bool Insert(Models.Customer customer)
        {
            return ICustomerDAL.Insert(customer);
        }
        public bool Update(Models.Customer customerUpdate)
        {
            return ICustomerDAL.Update(customerUpdate);
        }
        public bool DeleteByID(int ID)
        {
            return ICustomerDAL.DeleteByID(ID);
        }
        public List<Models.Customer> SelectAll()
        {
            return ICustomerDAL.SelectAll();
        }
        public Models.Customer SelectByID(int ID)
        {
            return ICustomerDAL.SelectByID(ID);
        }
        public bool CheckByID(int ID)
        {
            return ICustomerDAL.CheckByID(ID);
        }
    }
}

