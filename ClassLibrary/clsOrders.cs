using System;

namespace ClassLibrary
{
    public class clsOrders
    {

        public bool Active { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public int OrderId { get; set; }
        public string OrderContents { get; set; }
        public bool DispatchedStatus { get; set; }
        public double TotalPrice { get; set; }
        public string DeliveryAddress { get; set; }
        public bool PaymentConfirmed { get; set; }
    }
}