using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method

        string CustomerName = "Jefery";
        string CustomerEmail = "Jefery@gmail.com";
        string CustomerBillingAddress = "69 Zoo Doe";
        string CustomerShippingAddress = "69 Zoo Doe";
        string DateWhenJoined = DateTime.Now.Date.ToString();
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

            AnCustomer.DateWhenJoined = TestData;

            Assert.AreEqual(AnCustomer.DateWhenJoined, TestData);


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

            Int32 CustomerNo = 2;

            Found = AnCustomer.Find(CustomerNo);

            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerNo = 2;
           // AnCustomer.CustomerNo = CustomerNo;
            Found = AnCustomer.Find(CustomerNo);

            if (AnCustomer.CustomerNo != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
[TestMethod]
public void TestDateWhenJoinedFound()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerNo = 2;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.DateWhenJoined != Convert.ToDateTime("27/02/2020"))
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

            Int32 CustomerNo = 2;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.CustomerName != "Doe Cameron")
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

            Int32 CustomerNo = 2;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.CustomerEmail != "doecameron@hotmail.com")
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

            Int32 CustomerNo = 2;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.CustomerBillingAddress != "69 Zoo Doe")
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

            Int32 CustomerNo = 2;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.CustomerShippingAddress != "69 Zoo Doe")
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

            Int32 CustomerNo = 2;

            Found = AnCustomer.Find(CustomerNo);

            if(AnCustomer.CurrentOrder != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string varibale to store any error message
            String Error = "";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerBillingAddress, CustomerShippingAddress, DateWhenJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateWhenJoinedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store any test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateWhenJoined = TestDate.ToString();
            //invoke method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerBillingAddress, CustomerShippingAddress, DateWhenJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateWhenJoinedMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateWhenJoined = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerBillingAddress, CustomerShippingAddress, DateWhenJoined);
            Assert.AreNotEqual(Error, " ");
        }
           [TestMethod]
           public void DateWhenJoinedMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateWhenJoined = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerBillingAddress, CustomerShippingAddress, DateWhenJoined);
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void DateWhenJoinedMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = " ";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateWhenJoined = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerBillingAddress, CustomerShippingAddress, DateWhenJoined);
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void DateWhenJoinedExtermeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(100);
            string DateWhenJoined = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerBillingAddress, CustomerShippingAddress, DateWhenJoined);
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void DateWhenJoinedInvalidData()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string DateWhenJoined = "this is not a date!";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerBillingAddress, CustomerShippingAddress, DateWhenJoined);
            Assert.AreNotEqual(Error, " ");
        }
                }

}
