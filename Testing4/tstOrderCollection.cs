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

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderId = 99;
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
            AllOrder.Delete();
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderId = 89;
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

            TestItem.DeliveryAddress = "A new Address";
            TestItem.DispatchedStatus = false;
            TestItem.UnitPrice = 6.99;
            TestItem.Quantity = 5;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductCode = "ABC1245";
            TestItem.ItemId = 1;
            AllOrder.ThisOrder = TestItem;

            AllOrder.Update();
            AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ReportByProductCodeMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByProductCode("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByProductCodeNoneFound()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByProductCode("xxxxxxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByProductCodeTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;

            FilteredOrders.ReportByProductCode("YYY4321");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrdersList[0].OrderId != 155)
                {
                    OK = false;
                }
                if (FilteredOrders.OrdersList[1].OrderId != 156)
                {
                    OK = false;
                }
            } else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
