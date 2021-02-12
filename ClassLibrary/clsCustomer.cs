using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerNo;
        public Int32 CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }

        }
        private DateTime mDateJoined;
            public DateTime DateJoined
        {
            get
            {
                return mDateJoined;
            }
            set
            {
                mDateJoined = value;
            }
        }
        private Boolean mCurrentOrder;

        public bool CurrentOrder
        {
            get
            {
                return mCurrentOrder;
            }
            set
            {
                mCurrentOrder = value;
            }
        }
        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }
        private string mCustomerEmail;
        public string CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }

        private string mCustomerBillingAddress;
        public string CustomerBillingAddress
        {
            get
            {
                return mCustomerBillingAddress;
            }
            set
            {
                mCustomerBillingAddress = value;
            }
        }
        private string mCustomerShippingAddress;
        public string CustomerShippingAddress
        {
            get
            {
                return mCustomerShippingAddress;
            }
            set
            {
                mCustomerShippingAddress = value;
            }
        }
        public bool Find(int CustomerNo)
        {
            mCustomerNo = 21;
            mDateJoined = Convert.ToDateTime("16/09/2015");
            mCurrentOrder = true;
            mCustomerName = "Test Name";
            mCustomerEmail = "Test Email@";
            mCustomerBillingAddress = "Test Customer billing address";
            mCustomerShippingAddress = "Test Customer Shippping Address";
            return true;
        }

        
      
       
       
        
        
      

      
    }
}