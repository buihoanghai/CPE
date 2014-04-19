using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Models
{
    public class CreditCard
    {
        [Required(ErrorMessage = "Name On Card is required")]
        public string NameOnCard { get; set; }
        [Required(ErrorMessage = "Card Number is required")]
        public string CardNumber { get; set; }
        //[Required(ErrorMessage = "Expiry Date is required")]
        //[DateTimeNow(MinDay = 1)]
        public DateTime? ExpireDate { get; set; }
    }
    public class DateOfBirthAttribute : ValidationAttribute
    {
        public int MinAge { get; set; }
        public int MaxAge { get; set; }

        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            var val = (DateTime)value;

            if (val.AddYears(MinAge) > DateTime.Now)
                return false;

            return (val.AddYears(MaxAge) > DateTime.Now);
        }
    }
    public class DateTimeNowAttribute : ValidationAttribute
    {
        public int MinDay { get; set; }
        public int MaxDay { get; set; }

        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            var val = (DateTime)value;

            if (val.AddDays(MinDay) < DateTime.Now)
                return false;
            else return true;
            return (val.AddDays(MaxDay) > DateTime.Now);
        }
    }
}
