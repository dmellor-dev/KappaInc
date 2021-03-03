using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tsStock
    {
        //good test data
        int ItemID = 2;
        string ItemName = "HP v24i Full HD";
        string ItemType = "Monitor";
        int StockQuantity = 15;
        Double Price = 100.00;
        Boolean Available = true;
        string Supplier = "HP";
        string NextRestock = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(someStock);
        }

        [TestMethod]
        public void ItemIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            someStock.ItemID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(someStock.ItemID, TestData);
        }

        [TestMethod]
        public void ItemNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Test";
            //assign the data to the property
            someStock.ItemName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(someStock.ItemName, TestData);
        }

        [TestMethod]
        public void ItemTypePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Test";
            someStock.ItemType = TestData;
            Assert.AreEqual(someStock.ItemType, TestData);
        }

        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            someStock.StockQuantity = TestData;
            Assert.AreEqual(someStock.StockQuantity, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //create some test data to assign to the property
            double TestData = 29.99;
            someStock.Price = TestData;
            Assert.AreEqual(someStock.Price, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            someStock.Available = TestData;
            Assert.AreEqual(someStock.Available, TestData);
        }

        [TestMethod]
        public void SupplierPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Test";
            someStock.Supplier = TestData;
            Assert.AreEqual(someStock.Supplier, TestData);
        }

        [TestMethod]
        public void NextRestockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            someStock.NextRestock = TestData;
            Assert.AreEqual(someStock.NextRestock, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int ItemID = 2;
            //invoke the method
            Found = someStock.Find(ItemID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestItemIDNoFound()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int ItemID = 2;
            //invoke the method
            Found = someStock.Find(ItemID);
            //check the ItemID
            if (someStock.ItemID != 2)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameNoFound()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ItemID = 2;
            Found = someStock.Find(ItemID);
            if (someStock.ItemName != "HP v24i Full HD")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemTypeNoFound()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ItemID = 2;
            Found = someStock.Find(ItemID);
            if (someStock.ItemType != "Monitor")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockQuantityNoFound()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ItemID = 2;
            Found = someStock.Find(ItemID);
            if (someStock.StockQuantity != 15)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceNoFound()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ItemID = 2;
            Found = someStock.Find(ItemID);
            if (someStock.Price != 100)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableNoFound()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ItemID = 2;
            Found = someStock.Find(ItemID);
            if (someStock.Available != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNoFound()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ItemID = 2;
            Found = someStock.Find(ItemID);
            if (someStock.Supplier != "HP")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNextRestockNoFound()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ItemID = 2;
            Found = someStock.Find(ItemID);
            if (someStock.NextRestock != Convert.ToDateTime("26/07/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinLessOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemName = "";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinBoundary()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "A";
            //create test data to pass the method
            string ItemName = "";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemName = "Ab";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemName = "";
            ItemName = ItemName.PadRight(49, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxBoundary()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemName = "";
            ItemName = ItemName.PadRight(50, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemName = "";
            ItemName = ItemName.PadRight(51, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMid()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemName = "";
            ItemName = ItemName.PadRight(25, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameExtremeMax()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemName = "";
            ItemName = ItemName.PadRight(1000, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMinLessOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemType = "";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMinBoundary()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "A";
            //create test data to pass the method
            string ItemType = "";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMinPlusOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemType = "Ab";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMaxLessOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemType = "";
            ItemType = ItemType.PadRight(49, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMaxBoundary()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemType = "";
            ItemType = ItemType.PadRight(50, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMaxPlusOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemType = "";
            ItemType = ItemType.PadRight(51, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMid()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemType = "";
            ItemType = ItemType.PadRight(25, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeExtremeMax()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string ItemType = "";
            ItemType = ItemType.PadRight(1000, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMinLessOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string Supplier = "";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMinBoundary()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "A";
            //create test data to pass the method
            string Supplier = "";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMinPlusOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string Supplier = "Ab";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMaxLessOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string Supplier = "";
            Supplier = Supplier.PadRight(49, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMaxBoundary()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string Supplier = "";
            Supplier = Supplier.PadRight(50, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMaxPlusOne()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string Supplier = "";
            Supplier = Supplier.PadRight(51, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMid()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string Supplier = "";
            Supplier = Supplier.PadRight(25, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierExtremeMax()
        {
            clsStock someStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data to pass the method
            string Supplier = "";
            Supplier = Supplier.PadRight(1000, 'a');
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NextRestockExtremeMin()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //Set date to 100 years ago
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            //convert the test date to a string 
            string NextRestock = TestDate.ToString();
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NextRestockMinLessOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //Set date to yesterday
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            //convert the test date to a string 
            string NextRestock = TestDate.ToString();
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NextRestockMinBoundary()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //Set date to today
            TestDate = DateTime.Now.Date;
            //convert the test date to a string 
            string NextRestock = TestDate.ToString();
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NextRestockMinPlusOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //Set date to tomorrow
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            //convert the test date to a string 
            string NextRestock = TestDate.ToString();
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NextRestockExtremeMax()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //Set date to 100 years from now
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            //convert the test date to a string 
            string NextRestock = TestDate.ToString();
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NextRestockInvalidData()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            //create a variable to store the test data
            //Set NextRestock to some non date data
            string NextRestock = "Not a date";
            //invoke the method
            Error = someStock.Valid(ItemName, ItemType, Supplier, NextRestock);
            Assert.AreNotEqual(Error, "");
        }
    }
}
