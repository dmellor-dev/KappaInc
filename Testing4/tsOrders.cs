using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;


namespace Testing4
{
    [TestClass]
    public class tsOrders
    {
        int OrderId = 32;
        int ItemId = 1;
        DateTime OrderDate = DateTime.Now.Date;
        string DeliveryAddress = "An Address";
        bool DispatchedStatus = true;
        double UnitPrice = 9.99;
        int Quantity = 2;
        string ProductCode = "ABC1234";



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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdExtremeMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = -2147483648;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = -1;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 0;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 1;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 999998;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 999999;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 1000000;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 500000;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 2147483647;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemIdExtremeMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = -2147483648;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemIdMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = -1;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemIdMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 0;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIdMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 1;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIdMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 999998;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIdMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 999999;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIdMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 1000000;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemIdMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 500000;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIdExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int OrderId = 2147483647;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            OrderDate = TestDate;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            OrderDate = TestDate;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            OrderDate = TestDate;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            OrderDate = TestDate;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            OrderDate = TestDate;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string DeliveryAddress = "";
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string DeliveryAddress = "a";
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string DeliveryAddress = "aa";
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(199, 'a');
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(200, 'a');
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(201, 'a');
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(500, 'a');
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int Quantity = -2147483648;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int Quantity = -1;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int Quantity = 0;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int Quantity = 1;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int Quantity = 99;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int Quantity = 100;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int Quantity = 101;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int Quantity = 50;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            int Quantity = 2147483647;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductCodeMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ProductCode = "";
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductCodeMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ProductCode = "a";
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductCodeMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ProductCode = "aa";
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductCodeMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ProductCode = "aaaaaa";
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductCodeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ProductCode = "aaaaaaa";
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductCodeMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ProductCode = "aaaaaaaa";
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductCodeExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ProductCode = "";
            ProductCode = ProductCode.PadRight(500, 'a');
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceExtremeMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Double UnitPrice = Double.MinValue;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Double UnitPrice = -1.00;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Double UnitPrice = 0.00;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Double UnitPrice = 1.00;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Double UnitPrice = 9999.00;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Double UnitPrice = 10000.00;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Double UnitPrice = 10001.00;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Double UnitPrice = 5000.00;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Double UnitPrice = Double.MaxValue;
            Error = AnOrder.Valid(OrderId, ItemId, OrderDate, DeliveryAddress, DispatchedStatus, UnitPrice, Quantity, ProductCode);
            Assert.AreNotEqual(Error, "");
        }
    }

}
