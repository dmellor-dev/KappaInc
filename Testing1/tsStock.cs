using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tsStock
    {
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
            if (someStock.NextRestock != Convert.ToDateTime("26/07/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
