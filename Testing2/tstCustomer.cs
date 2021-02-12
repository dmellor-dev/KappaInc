using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void CurrentOrderPropertyOK()
        {
            // this section runs a test to make sure that a boolean data is in the CurrentOrder attribute 
            clsCustomer AnCustomer = new clsCustomer();

            Boolean TestData = true;

            AnCustomer.CurrentOrder = TestData;

            Assert.AreEqual(AnCustomer.CurrentOrder, TestData);
          
        }

        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            // this section runs a test to make sure that a date type is in the datejoined attribute
            clsCustomer AnCustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            AnCustomer.DateJoined = TestData;

            Assert.AreEqual(AnCustomer.DateJoined, TestData);


        }
        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            // this section runs a test to make sure that a int type is in the customerNo attribute
            clsCustomer AnCustomer = new clsCustomer();

            Int32 TestData = 1;

            AnCustomer.CustomerNo = TestData;

            Assert.AreEqual(AnCustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOk()
        {
            // this section runs a test to make sure that a string type is in the CustomerName attribute
            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "James";

            AnCustomer.CustomerName = TestData;

            Assert.AreEqual(AnCustomer.CustomerName, TestData);
         
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            // this section runs a test to make sure that a string type is in the CustomerEmail attribute
            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "James@gmail.com";

            AnCustomer.CustomerEmail = TestData;

            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);

        
        }

        [TestMethod]
        public void CustomerBillingAddressPropertyOK()
        {
            // this section runs a test to make sure that a string type is in the CustomerBillingAddress attribute
            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "32 Justin Street SY7 8TY";

            AnCustomer.CustomerBillingAddress = TestData;

            Assert.AreEqual(AnCustomer.CustomerBillingAddress, TestData);
        }

        [TestMethod]
        public void CustomerShippingAddressPropertyOK()
        {
            // this section runs a test to make sure that a string type is in the CustomerShippingAddress attribute
            clsCustomer AnCustomer = new clsCustomer();

            String TestData = "32 Justin Street SY7 8TY";

            AnCustomer.CustomerShippingAddress = TestData;

            Assert.AreEqual(AnCustomer.CustomerShippingAddress, TestData); 
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Int32 CustomerNo = 21;

            Found = AnCustomer.Find(CustomerNo);

            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerNo = 21;
           // AnCustomer.CustomerNo = CustomerNo;
            Found = AnCustomer.Find(CustomerNo);

            if (AnCustomer.CustomerNo != 21)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
[TestMethod]
public void TestDateJoinedFound()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerNo = 21;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.DateJoined != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;

            }
            Assert.IsTrue(OK);




        }
   [TestMethod]
   public void TestCustomerNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerNo = 21;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.CustomerName != "Test Name")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerNo = 21;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.CustomerEmail != "Test Email@")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerBillingAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerNo = 21;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.CustomerBillingAddress != "Test Customer billing address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerShippingAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerNo = 21;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.CustomerShippingAddress != "Test Customer Shippping Address")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAnyCurrentOrdersFound()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerNo = 21;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.CurrentOrder != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
