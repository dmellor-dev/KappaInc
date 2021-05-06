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
        private DateTime mDateWhenJoined;
        public DateTime DateWhenJoined
        {
            get
            {
                return mDateWhenJoined;
            }
            set
            {
                mDateWhenJoined = value;
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
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for 
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)

            {
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mDateWhenJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateWhenJoined"]);
                mCurrentOrder = Convert.ToBoolean(DB.DataTable.Rows[0]["CurrentOrder"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerBillingAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerBillingAddress"]);
                mCustomerShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerShippingAddress"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string customerName, string customerEmail, string customerBillingAddress, string customerShippingAddress, string dateWhenJoined)
        {
            String Error = "";
            DateTime Datetemp;
            try
            {
                Datetemp = Convert.ToDateTime(dateWhenJoined);
                if (Datetemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past :";
                }
                if (Datetemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date: ";
            }
            return Error;
        }
        
    }
}