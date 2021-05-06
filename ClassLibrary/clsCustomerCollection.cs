using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
                
                }

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.CurrentOrder = Convert.ToBoolean(DB.DataTable.Rows[Index]["CurrentOrder"]);
                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerBillingAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerBillingAddress"]);
                AnCustomer.CustomerShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerShippingAddress"]);
                mCustomerList.Add(AnCustomer);
                Index++;

            }
            




        }

        public int Add()
        {
            //adds a new record to the database on the values of thisCustomer
            //connect to the databasse
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CurrentOrder", mThisCustomer.CurrentOrder);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerBillingAddress", mThisCustomer.CustomerBillingAddress);
            DB.AddParameter("@CustomerShippingAddress", mThisCustomer.CustomerShippingAddress);
            DB.AddParameter("@DateWhenJoined", mThisCustomer.DateWhenJoined);
            return DB.Execute("sproc_tblCustomer_Insert");
        }
        
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@CurrentOrder", mThisCustomer.CurrentOrder);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerBillingAddress", mThisCustomer.CustomerBillingAddress);
            DB.AddParameter("@CustomerShippingAddress", mThisCustomer.CustomerShippingAddress);
            DB.AddParameter("@DateWhenJoined", mThisCustomer.DateWhenJoined);
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}