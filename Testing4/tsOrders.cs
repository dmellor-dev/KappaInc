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
        public void OrderContentsOK()
        {
            clsOrders AnOrder = new clsOrders();
            String TestData = "Some products in an order";
            AnOrder.OrderContents = TestData;
            Assert.AreEqual(AnOrder.OrderContents, TestData);
        }

        [TestMethod]
        public void DeliveryDateAddedPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.ExpectedDeliveryDate = TestData;
            Assert.AreEqual(AnOrder.ExpectedDeliveryDate, TestData);
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
        public void TotalPriceOK()
        {
            clsOrders AnOrder = new clsOrders();
            Double TestData = 12.32;
            AnOrder.TotalPrice = TestData;
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
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
        public void PaymentConfirmedOK()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean TestData = true;
            AnOrder.PaymentConfirmed = TestData;
            Assert.AreEqual(AnOrder.PaymentConfirmed, TestData);
        }
    }

}
