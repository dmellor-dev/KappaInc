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
            clsStock someStock = new clsStock();
            Assert.IsNotNull(someStock);
        }

        [TestMethod]
        public void ItemIDPropertyOK()
        {
            clsStock someStock = new clsStock();
            int TestData = 1;
            someStock.ItemID = TestData;
            Assert.AreEqual(someStock.ItemID, TestData);
        }

        [TestMethod]
        public void ItemNamePropertyOK()
        {
            clsStock someStock = new clsStock();
            string TestData = "Test";
            someStock.ItemName = TestData;
            Assert.AreEqual(someStock.ItemName, TestData);
        }

        [TestMethod]
        public void ItemTypePropertyOK()
        {
            clsStock someStock = new clsStock();
            string TestData = "Test";
            someStock.ItemType = TestData;
            Assert.AreEqual(someStock.ItemType, TestData);
        }

        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            clsStock someStock = new clsStock();
            int TestData = 1;
            someStock.StockQuantity = TestData;
            Assert.AreEqual(someStock.StockQuantity, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock someStock = new clsStock();
            double TestData = 29.99;
            someStock.Price = TestData;
            Assert.AreEqual(someStock.Price, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            clsStock someStock = new clsStock();
            Boolean TestData = true;
            someStock.Available = TestData;
            Assert.AreEqual(someStock.Available, TestData);
        }

        [TestMethod]
        public void SupplierPropertyOK()
        {
            clsStock someStock = new clsStock();
            string TestData = "Test";
            someStock.Supplier = TestData;
            Assert.AreEqual(someStock.Supplier, TestData);
        }

        [TestMethod]
        public void NextRestockPropertyOK()
        {
            clsStock someStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            someStock.NextRestock = TestData;
            Assert.AreEqual(someStock.NextRestock, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock someStock = new clsStock();
            Boolean Found = false;
            int ItemID = 2;
            Found = someStock.Find(ItemID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestItemIDNoFound()
        {
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            int ItemID = 2;
            Found = someStock.Find(ItemID);
            if (someStock.ItemID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameNoFound()
        {
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
