using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class DeviceTransactions
    {
        public string Barcode { get; set; }
        public string SIMNo { get; set; }
        public int Status { get; set; }
        public int SiteLoan_ID { get; set; }
        public string Name { get; set; }
        public string Passport { get; set; }
        public string DrivingLisence { get; set; }
        public string IDLisence { get; set; }
        public DateTime LoanDate { get; set; }
    }
}
