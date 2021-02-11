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
    }
}
