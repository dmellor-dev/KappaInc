using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }
[TestMethod]
public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assgin to th property 
            // in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CurrentOrder = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Jeff";
            TestItem.CustomerEmail = "Jeff@gmail.com";
            TestItem.CustomerShippingAddress = "23 Doe Zoo";
            TestItem.CustomerBillingAddress = "23 Doe Zoo";
            TestItem.DateWhenJoined = DateTime.Now.Date;
            // add the item to the test list
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }
        

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CurrentOrder = true;
            TestCustomer.CustomerNo = 1;
            TestCustomer.CustomerName = "Jeff";
            TestCustomer.CustomerEmail = "Jeff@gmail.com";
            TestCustomer.CustomerShippingAddress = "23 Doe Zoo";
            TestCustomer.CustomerBillingAddress = "23 Doe Zoo";
            TestCustomer.DateWhenJoined = DateTime.Now.Date;
            AllCustomer.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }
        
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.CurrentOrder = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Jeff";
            TestItem.CustomerEmail = "Jeff@gmail.com";
            TestItem.CustomerShippingAddress = "23 Doe Zoo";
            TestItem.CustomerBillingAddress = "23 Doe Zoo";
            TestItem.DateWhenJoined = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }
      
        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CurrentOrder = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Jeff";
            TestItem.CustomerEmail = "Jeff@gmail.com";
            TestItem.CustomerShippingAddress = "23 Doe Zoo";
            TestItem.CustomerBillingAddress = "23 Doe Zoo";
            TestItem.DateWhenJoined = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //Add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }


        [TestMethod]

        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.CurrentOrder = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Jeff";
            TestItem.CustomerEmail = "Jeff@gmail.com";
            TestItem.CustomerShippingAddress = "23 Doe Zone";
            TestItem.CustomerBillingAddress = "23 Doe Zone";
            TestItem.DateWhenJoined = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the test data
            TestItem.CurrentOrder = false;
            TestItem.CustomerNo = 6;
            TestItem.CustomerName = "Jeffyy";
            TestItem.CustomerEmail = "Jeffyy@gmail.com";
            TestItem.CustomerShippingAddress = "32 Doe Zone";
            TestItem.CustomerBillingAddress = "32 Doe Zone";
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
       
        [TestMethod]

        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CurrentOrder = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Jeff";
            TestItem.CustomerEmail = "Jeff@gmail.com";
            TestItem.CustomerShippingAddress = "23 Doe Zone";
            TestItem.CustomerBillingAddress = "23 Doe Zone";
            TestItem.DateWhenJoined = DateTime.Now.Date;
            AllCustomers.ThisCustomer = TestItem;
        
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerNo = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
public void ReportByShippingAddressMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerShippingAddress("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByShippingAddressNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerShippingAddress("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

    }
}
