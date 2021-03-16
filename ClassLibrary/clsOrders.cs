using System;

namespace ClassLibrary
{
    public class clsOrders
    {

        public bool Active { get; set; }
        public DateTime OrderDate {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        public Int32 OrderId {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;   
            }
        }

        public string DeliveryAddress {
            get
            {
                return mDeliveryAddress;
            }
            set
            {
                mDeliveryAddress = value;
            }
        }
        public bool DispatchedStatus {
            get
            {
                return mDispatchedStatus;
            }
            set
            {
                mDispatchedStatus = value;
            }
        }
        public double UnitPrice {
            get
            {
                return mUnitPrice;
            }
            set
            {
                mUnitPrice = value;
            }
        }
        public Int32 Quantity {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public string ProductCode {
            get
            {
                return mProductCode;
            }
            set
            {
                mProductCode = value;
            }
        }
        public int ItemId {
            get
            {
                return mItemId;
            }
            set
            {
                mItemId = value;
            }
        }

        private Int32 mOrderId;
        private DateTime mOrderDate;
        private string mDeliveryAddress;
        private bool mDispatchedStatus;
        private double mUnitPrice;
        private Int32 mQuantity;
        private string mProductCode;
        private int mItemId;

        public bool Find(int orderId)
        {
            bool tblOrderCorrect;
            bool tblOrderlineCorrect;

            clsDataConnection DBO = new clsDataConnection();
            DBO.AddParameter("@OrderId", orderId);
            DBO.Execute("sproc_tblOrder_FilterByOrderId");

            if (DBO.Count == 1)
            {
                tblOrderCorrect = true;
                mOrderId = Convert.ToInt32(DBO.DataTable.Rows[0]["OrderId"]);
                mOrderDate = Convert.ToDateTime(DBO.DataTable.Rows[0]["OrderDate"]);
                mDispatchedStatus = Convert.ToBoolean(DBO.DataTable.Rows[0]["DispatchedStatus"]);
                mDeliveryAddress = Convert.ToString(DBO.DataTable.Rows[0]["DeliveryAddress"]);
            }
            else
            {
                tblOrderCorrect = false;
            }

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", orderId);
            DB.Execute("sproc_tblOrderline_Filter_By_OrderId");
            if (DB.Count == 1)
            {
                tblOrderlineCorrect = true;
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mItemId = Convert.ToInt32(DB.DataTable.Rows[0]["ItemId"]);
                mUnitPrice = Convert.ToDouble(DB.DataTable.Rows[0]["UnitPrice"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mProductCode = Convert.ToString(DB.DataTable.Rows[0]["ProductCode"]);
            } else
            {
                tblOrderlineCorrect = false;
            }


            if (tblOrderCorrect && tblOrderlineCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public string Valid(int orderId, int itemId, DateTime orderDate, string deliveryAddress, bool dispatchedStatus, double unitPrice, int quantity, string productCode)
        {
            String Error = "";
            DateTime DateTemp;

            if (orderId < 0)
            {
                Error = Error + "The Order ID may not be negative or blank : ";
            }

            if (orderId > 999999)
            {
                Error = Error + "The Order ID may not be greater than 999999 : ";
            }

            if (itemId < 0)
            {
                Error = Error + "The Item ID may not be negative or blank : ";
            }

            if (itemId > 999999)
            {
                Error = Error + "The Item ID may not be greater than 999999 : ";
            }

            DateTemp = orderDate;
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The Date cannot be in the past";
            }
            
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The Date cannot be in the future";
            }
            
            if (deliveryAddress.Length == 0)
            {
                Error = Error + "The Delivery Address may not be blank : ";
            }

            if (deliveryAddress.Length > 200)
            {
                Error = Error + "The Delivery Address cannot exceed 200 characters";
            }

            if (quantity < 0)
            {
                Error = Error + "The Item Quantity may not be negative or blank : ";
            }

            if (quantity > 100)
            {
                Error = Error + "The Item Quantity may not be greater than 100 : ";
            }

            if (productCode.Length == 0)
            {
                Error = Error + "The Product Code may not be blank : ";
            }

            if (productCode.Length > 7)
            {
                Error = Error + "The Delivery Address cannot exceed 200 characters";
            }

            if (unitPrice < 0)
            {
                Error = Error + "The Unit Price may not be negative : ";
            }

            if (unitPrice > 10000)
            {
                Error = Error + "The Unit Price may not be above 10000.00 : ";
            }

            return Error;
        }
    }
}