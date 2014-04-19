using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Delivery
    {
        public int DeviceQTY { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int DeliveryTime { get; set; }
        public DateTime ReturnDate { get; set; }
        public int ReturnTime { get; set; }
        public string BookedName { get; set; }
        public string DeliveryAddress { get; set; }
        public string PromotionCode { get; set; }
        public string AgentCode { get; set; }

    }
}
