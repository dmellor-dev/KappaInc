using System;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mItemID;
        private string mItemName;
        private string mItemType;
        private Int32 mStockQuantity;
        private double mPrice;
        private bool mAvailable;
        private string mSupplier;
        private DateTime mNextRestock;
        public Int32 ItemID
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
        public Int32 StockQuantity
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
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the ItemID to search for
            DB.AddParameter("@ItemID", itemID);
            //Exectute the stored procedure
            DB.Execute("sproc_tblStock_FilterByItemID");
            //If one record is found (There should either by one of none)
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mItemID = Convert.ToInt32(DB.DataTable.Rows[0]["ItemID"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mItemType = Convert.ToString(DB.DataTable.Rows[0]["ItemType"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mSupplier = Convert.ToString(DB.DataTable.Rows[0]["Supplier"]);
                mNextRestock = Convert.ToDateTime(DB.DataTable.Rows[0]["NextRestock"]);
                //Return that everything worked properly
                return true;
            }
            //If no record was found
            else
            {
                //Return false, indicating a problem
                return false;
            }
        }

        public string Valid(string ItemName, string ItemType, string StockQuantity, string Price, string Supplier, string NextRestock)
        {

            string Error = "";
            DateTime DateTemp;

            if (ItemName.Length > 50)
            {
                Error = Error + "The item name cannot exceed 50 characters";
            }

            if (ItemType.Length > 50)
            {
                Error = Error + "The item type cannot exceed 50 characters";
            }

            if (!Regex.IsMatch(StockQuantity, @"^\d+$"))
            {
                Error = Error + "The Stock Quantity must be numeric only";
            }

            Double num = 0;
            if (!double.TryParse(Price, out num))
            {
                Error = Error + "The price must be a decimal number";
            }

            if (Supplier.Length > 50)
            {
                Error = Error + "The supplier cannot exceed 50 characters";
            }
            try
            {
                DateTemp = Convert.ToDateTime(NextRestock);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The next restock date cannot be in the past : ";
                }
            }
            catch
            {
                Error = Error + "the date was not a valid date : ";
            }
            
            return Error;
        }
    }
}