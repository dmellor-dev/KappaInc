using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tsItemCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsItemCollection AllItems = new clsItemCollection();
            //test to see that it exists
            Assert.IsNotNull(AllItems);
        }

        [TestMethod]
        public void ItemListOK()
        {
            //create an instance of the class we want to create
            clsItemCollection AllItems = new clsItemCollection();
            //create some test data to assign to the property
            List<clsStock> TestList = new List<clsStock>();
            //add items to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //Set its properties
            TestItem.Available = true;
            TestItem.ItemName = "TestItem";
            TestItem.ItemType = "Monitor";
            TestItem.StockQuantity = 10;
            TestItem.Price = 10.00;
            TestItem.Supplier = "KappaInc";
            TestItem.NextRestock = DateTime.Now.Date.AddDays(1);
            //Add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllItems.ItemList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllItems.ItemList, TestList);
        }

        [TestMethod]
        public void ThisItemPropertyOK()
        {
            clsItemCollection AllItems = new clsItemCollection();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.ItemName = "TestItem";
            TestItem.ItemType = "Monitor";
            TestItem.StockQuantity = 10;
            TestItem.Price = 10.00;
            TestItem.Supplier = "KappaInc";
            TestItem.NextRestock = DateTime.Now.Date.AddDays(1);
            AllItems.ThisItem = TestItem;
            Assert.AreEqual(AllItems.ThisItem, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsItemCollection AllItems = new clsItemCollection();
            //create some test data to assign to the property
            List<clsStock> TestList = new List<clsStock>();
            //add items to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //Set its properties
            TestItem.Available = true;
            TestItem.ItemName = "TestItem";
            TestItem.ItemType = "Monitor";
            TestItem.StockQuantity = 10;
            TestItem.Price = 10.00;
            TestItem.Supplier = "KappaInc";
            TestItem.NextRestock = DateTime.Now.Date.AddDays(1);
            //Add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllItems.ItemList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllItems.Count, TestList.Count);
        }
      
        [TestMethod]
        public void AddMethodOK()
        {
            clsItemCollection AllItems = new clsItemCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.ItemID = 10; //This will only work once because it adds the test item to the list meaning there is now a duplicate, so change this value each time or remove it from the database
            TestItem.Available = true;
            TestItem.ItemName = "TestItem";
            TestItem.ItemType = "Monitor";
            TestItem.StockQuantity = 10;
            TestItem.Price = 10.00;
            TestItem.Supplier = "KappaInc";
            TestItem.NextRestock = DateTime.Now.Date.AddDays(1);
            //set ThisItem to the test data
            AllItems.ThisItem = TestItem;
            //add the record
            PrimaryKey = AllItems.Add();
            //set the primary key of the test data
            TestItem.ItemID = PrimaryKey;
            //find the record
            AllItems.ThisItem.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllItems.ThisItem, TestItem);
        }
    }
}
