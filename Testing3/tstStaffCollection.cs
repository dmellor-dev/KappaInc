using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();
            TestItem.StaffId = 101;
            TestItem.FirstName = "Joe";
            TestItem.LastName = "Bennet";
            TestItem.EmailAddress = "jb@email.com";
            TestItem.HomeAddress = "101 Joe Ln, LE1 101";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.IsWorking = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 0;
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }
        [TestMethod]
        public void ThisStaffMemberOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestStaff = new clsStaff();
            TestStaff.StaffId = 101;
            TestStaff.FirstName = "Joe";
            TestStaff.LastName = "Bennet";
            TestStaff.EmailAddress = "jb@email.com";
            TestStaff.HomeAddress = "101 Joe Ln, LE1 101";
            TestStaff.StartDate = DateTime.Now.Date;
            TestStaff.IsWorking = true;

            AllStaff.ThisStaffMember = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaffMember, TestStaff);
        }
    }
}
