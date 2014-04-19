using System;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface ICustomersDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.Customer customer);
        System.Collections.Generic.List<Models.Customer> SelectAll();
        Models.Customer SelectByID(int ID);
        bool Update(Models.Customer customerUpdate);
        Models.Customer Login(string Username, string Password);
        Models.Customer SelectCustomerByEmailAndName(string Email, string Name);
        int GetMaxID();
        bool CheckCustomerByUsername(string Username);
    }
}
