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
    }
}
