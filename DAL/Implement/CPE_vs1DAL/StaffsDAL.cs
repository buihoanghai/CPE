using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class StaffsDAL:IStaffsDAL
    {
        public List<Models.Staff> GetAllStaffNotAdmin()
        {
            using (var db = new Models.DBContextCPEDB())
            {
                var staff = from s in db.Staffs
                            where s.ID != 1
                            select s;
                return staff.ToList();
            }
        }
        public bool Insert(Models.Staff staff)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Database.Connection.Open();
                    db.Staffs.Add(staff);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
                db.Database.Connection.Close();
            }
        }
        public bool Update(Models.Staff staffUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                db.Database.Connection.Open();
                try
                {
                    Models.Staff staff = db.Staffs.Single<Models.Staff>(c => c.ID == staffUpdate.ID);
                    staff.Name = staffUpdate.Name;
                    staff.DOB = staffUpdate.DOB;
                    staff.Address = staffUpdate.Address;
                    staff.Sex = staffUpdate.Sex;
                    staff.Phone = staffUpdate.Phone;
                    staff.Account = staffUpdate.Account;
                    staff.Password = staffUpdate.Password;
                    staff.AccountType = staffUpdate.AccountType;
                    staff.Site_ID = staffUpdate.Site_ID;
                    staff.Modified = staffUpdate.Modified;
                    staff.Modified_By = staffUpdate.Modified_By;
                    staff.HomePhone = staffUpdate.HomePhone;
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
                db.Database.Connection.Close();
            }
        }
        public bool DeleteByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                db.Database.Connection.Open();
                try{
                    var staff = db.Staffs.Single(c => c.ID == ID);
                    db.Staffs.Remove(staff);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
                db.Database.Connection.Close();
            }
        }
        public List<Models.Staff> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                db.Database.Connection.Open();
                try
                {
                    return db.Staffs.ToList();
                }
                catch { return null; }
                db.Database.Connection.Close();
            }
        }
        public Models.Staff SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                db.Database.Connection.Open();
                try
                {
                    return db.Staffs.Single(c => c.ID == ID);
                }
                catch { return null; }
                db.Database.Connection.Close();
            }
        }
        public bool CheckByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                db.Database.Connection.Open();
                try
                {
                    db.Staffs.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
                db.Database.Connection.Close();
           }
        }
        public bool CheckStaffByUsername(string UserName)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Staffs.Single(s => s.Account == UserName);
                    return true;
                }
                catch { return false; }
            }
        }

    }
}

