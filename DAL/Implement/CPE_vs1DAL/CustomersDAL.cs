using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class CustomersDAL:ICustomersDAL
    {
        public bool Insert(Models.Customer customer)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.Customer customerUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.Customer customer = db.Customers.Single<Models.Customer>(c => c.ID == customerUpdate.ID);
                    customer.Name = customerUpdate.Name;
                    customer.DOB = customerUpdate.DOB;
                    customer.Passport = customerUpdate.Passport;
                    customer.Nationality = customerUpdate.Nationality;
                    customer.Address = customerUpdate.Address;
                    customer.Expiry_date = customerUpdate.Expiry_date;
                    customer.Phone = customerUpdate.Phone;
                    customer.Modified_By = customerUpdate.Modified_By;
                    customer.Modified = customerUpdate.Modified;
                    customer.DrivingLisence = customerUpdate.DrivingLisence;
                    customer.IDLisence = customerUpdate.IDLisence;
                    customer.Email = customerUpdate.Email;
                    customer.UserName = customerUpdate.UserName;
                    customer.Password = customerUpdate.Password;
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool DeleteByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try{
                    var customer = db.Customers.Single(c => c.ID == ID);
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.Customer> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Customers.ToList();
                }
                catch { return null; }
            }
        }
        public Models.Customer SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Customers.Single(c => c.ID == ID);
                }
                catch { return null; }
            }
        }
        public bool CheckByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    db.Customers.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }


        public Models.Customer Login(string Username, string Password)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Customers.Single(c => c.Password == Password && ( c.UserName==Username || c.Email==Username ));
                }
                catch { return null; }
            }
        }


        public Models.Customer SelectCustomerByEmailAndName(string Email, string Name)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Customers.Single(c => c.Email == Email && c.Name.Contains(Name));
                }
                catch { return null; }
            }
        }


        public int GetMaxID()
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Customers.Max(c => c.ID);
                }
                catch { return 0; }
            }
        }


        public bool CheckCustomerByUsername(string Username)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Customers.Single(r => r.UserName == Username);
                    return true;
                }
                catch { return false; }
            }
        }
    }
}

