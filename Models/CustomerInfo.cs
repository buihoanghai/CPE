using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Models
{
    public class CustomerInfo
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "DOB is required")]
        //[DateOfBirth(MinAge = 18, MaxAge = 150)]
        public Nullable<System.DateTime> DOB { get; set; }
        [Required(ErrorMessage = "Identity Number is required")]
        public string Passport { get; set; }
        [Required(ErrorMessage = "Nationality is required")]
        public string Nationality { get; set; }
        public string Address { get; set; }
        //[Required(ErrorMessage = "Expiry Date is required")]
        //[DateTimeNow(MinDay = 1)]
        public Nullable<System.DateTime> Expiry_date { get; set; }
        public string Phone { get; set; }
        public Nullable<int> Modified_By { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string DrivingLisence { get; set; }
        public string IDLisence { get; set; }
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
