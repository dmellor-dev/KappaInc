using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tsOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrders AnOrder = new clsOrders();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean TestData = true;
            AnOrder.Active = TestData;
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void OrderIdOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 1;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

       
        [TestMethod]
        public void OrderDateAddedPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDeliveryDate = TestData;
            Assert.AreEqual(AnOrder.OrderDeliveryDate, TestData);
        }

        [TestMethod]
        public void DispatchedStatusOK()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean TestData = true;
            AnOrder.DispatchedStatus = TestData;
            Assert.AreEqual(AnOrder.DispatchedStatus, TestData);
        }

        [TestMethod]
        public void DeliveryAddressOK()
        {
            clsOrders AnOrder = new clsOrders();
            String TestData = "A customer address";
            AnOrder.DeliveryAddress = TestData;
            Assert.AreEqual(AnOrder.DeliveryAddress, TestData);
        }

        [TestMethod]
        public void UnitPriceOK()
        {
            clsOrders AnOrder = new clsOrders();
            Double TestData = 22.99;
            AnOrder.UnitPrice = TestData;
            Assert.AreEqual(AnOrder.UnitPrice, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 4;
            AnOrder.Quantity = TestData;
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }

        [TestMethod]
        public void ProductCodeOK()
        {
            clsOrders AnOrder = new clsOrders();
            String TestData = "AProduct1234";
            AnOrder.ProductCode = TestData;
            Assert.AreEqual(AnOrder.ProductCode, TestData);
        }

    }

}
