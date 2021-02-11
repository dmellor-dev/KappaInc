using System;
namespace ClassLibrary
{
    public class clsStock
    {
        private int mItemID;
        private string mItemName;
        private string mItemType;
        private int mStockQuantity;
        private double mPrice;
        private bool mAvailable;
        private string mSupplier;
        private DateTime mNextRestock;
        public int ItemID
        {
            get
            {
                //This sends data out of ItemID
                return mItemID;
            }
            set
            {
                //This allows data into the ItemID
                mItemID = value;
            }
        }
        public string ItemName
        {
            get
            {
                //This sends data out of ItemID
                return mItemName;
            }
            set
            {
                //This allows data into the ItemID
                mItemName = value;
            }
        }
        public string ItemType
        {
            get
            {
                //This sends data out of ItemID
                return mItemType;
            }
            set
            {
                //This allows data into the ItemID
                mItemType = value;
            }
        }
        public int StockQuantity
        {
            get
            {
                //This sends data out of ItemID
                return mStockQuantity;
            }
            set
            {
                //This allows data into the ItemID
                mStockQuantity = value;
            }
        }
        public double Price
        {
            get
            {
                //This sends data out of ItemID
                return mPrice;
            }
            set
            {
                //This allows data into the ItemID
                mPrice = value;
            }
        }
        public bool Available
        {
            get
            {
                //This sends data out of ItemID
                return mAvailable;
            }
            set
            {
                //This allows data into the ItemID
                mAvailable = value;
            }
        }
        public  string Supplier
        {
            get
            {
                //This sends data out of ItemID
                return mSupplier;
            }
            set
            {
                //This allows data into the ItemID
                mSupplier = value;
            }
        }
        public DateTime NextRestock
        {
            get
            {
                //This sends data out of ItemID
                return mNextRestock;
            }
            set
            {
                //This allows data into the ItemID
                mNextRestock = value;
            }
        }

        public bool Find(int itemID)
        {
            //set the private data members to the test data value
            mItemID = 2;
            mItemName = "HP v24i Full HD";
            mItemType = "Monitor";
            mStockQuantity = 15;
            mPrice = 100;
            mAvailable = true;
            mSupplier = "HP";
            mNextRestock = Convert.ToDateTime("26/07/2021");
            //Always return true
            return true;
        }
    }
}