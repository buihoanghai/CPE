using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Models
{
    public class LoanInfo
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Device Quantity is required")]
        public int DeviceQuantity { get; set; }
        [Required(ErrorMessage = "Collection Location is required")]
        public int CollectionLocation { get; set; }
        [Required(ErrorMessage = "Collection Date is required")]
        public DateTime? CollectionDate { get; set; }
        [Required(ErrorMessage = "Return Date is required")]
        public DateTime? ReturnDate { get; set; }
        [Required(ErrorMessage = "Rental Mode is required")]
        public string RentalMode { get; set; }
        public string Agent_Promotion_Code { get; set; }
        public string AgentCode { get; set; }
        public float RentalPrice { get; set; }
        public float OnlineDiscount { get; set; }
        public float Delivery { get; set; }
        public float Total { get; set; }
        public string CreditCard { get; set; }
        public string CreditCardNumer { get; set; }
        public Nullable<System.DateTime> ExpiredateCreditCard { get; set; }
        public string NameOnCard { get; set; }
        public string BookedName { get; set; }
        public string CustomerCode { get; set; }
        public string DeliveryAddress { get; set; }
    }
}
