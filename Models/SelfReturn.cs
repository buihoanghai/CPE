using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SelfReturn
    {
        public int DeviceQTY { get; set; }
        public int Location { get; set; }
        public DateTime PickDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string PromotionCode { get; set; }
        public string AgentCode { get; set; }
    }
}
