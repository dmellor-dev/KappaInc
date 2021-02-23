using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;


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
        public void ItemIdOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 1;
            AnOrder.ItemId = TestData;
            Assert.AreEqual(AnOrder.ItemId, TestData);
        }

       
        [TestMethod]
        public void OrderDateAddedPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Int32 OrderId = 32;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 32;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 32)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 32;
            Found = AnOrder.Find(OrderId);
            if(AnOrder.OrderDate != Convert.ToDateTime("15/2/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDeliveryAddressFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 32;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.DeliveryAddress != "An Address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDispatchedStatusFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 32;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.DispatchedStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderUnitPriceFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 32;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.UnitPrice != 9.99)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderQuantityFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 32;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Quantity != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderProductCodeFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 32;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ProductCode != "ABC1234")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderItemIdFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 32;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ItemId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }

}
