using System;

namespace ClassLibrary
{
    public class clsOrders
    {

        public bool Active { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public int OrderId { get; set; }
        public string DeliveryAddress { get; set; }

        public bool DispatchedStatus { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ProductCode { get; set; }
    }
}