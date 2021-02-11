using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool CurrentOrder { get; set; }
        public DateTime DateJoined { get; set; }
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerBillingAddress { get; set; }
        public string CustomerShippingAddress { get; set; }
    }
}