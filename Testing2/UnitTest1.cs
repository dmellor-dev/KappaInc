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
      
       
        
    }
}
