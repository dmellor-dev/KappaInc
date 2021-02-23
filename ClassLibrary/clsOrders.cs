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
    }
}