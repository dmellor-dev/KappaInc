using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrdersListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrders> TestList = new List<clsOrders>();

            clsOrders TestItem = new clsOrders();
            TestItem.OrderId = 1;
            TestItem.DeliveryAddress = "An Address";
            TestItem.DispatchedStatus = true;
            TestItem.UnitPrice = 5.99;
            TestItem.Quantity = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductCode = "ABC1234";
            TestItem.ItemId = 1;

            TestList.Add(TestItem);
            AllOrders.OrdersList = TestList;
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }
        [TestMethod]
        public void ThisOrdersOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrders TestOrders = new clsOrders();
            TestOrders.OrderId = 1;
            TestOrders.DeliveryAddress = "An Address";
            TestOrders.DispatchedStatus = true;
            TestOrders.UnitPrice = 5.99;
            TestOrders.Quantity = 2;
            TestOrders.OrderDate = DateTime.Now.Date;
            TestOrders.ProductCode = "ABC1234";
            TestOrders.ItemId = 1;

            AllOrders.ThisOrder = TestOrders;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrders> TestList = new List<clsOrders>();

            clsOrders TestItem = new clsOrders();
            TestItem.OrderId = 1;
            TestItem.DeliveryAddress = "An Address";
            TestItem.DispatchedStatus = true;
            TestItem.UnitPrice = 5.99;
            TestItem.Quantity = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductCode = "ABC1234";
            TestItem.ItemId = 1;

            TestList.Add(TestItem);
            AllOrders.OrdersList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderId = 1;
            TestItem.DeliveryAddress = "An Address";
            TestItem.DispatchedStatus = true;
            TestItem.UnitPrice = 5.99;
            TestItem.Quantity = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductCode = "ABC1234";
            TestItem.ItemId = 1;
            AllOrder.ThisOrder = TestItem;
            PrimaryKey = AllOrder.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
    }
}
