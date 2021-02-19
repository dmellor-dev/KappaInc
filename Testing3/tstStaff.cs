using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff StaffMember = new clsStaff();
            Assert.IsNotNull(StaffMember);
        }

        [TestMethod]
        public void IsWorkingPropertyOK()
        {
            clsStaff StaffMember = new clsStaff();
            //Creating test data
            Boolean TestData = true;
            //Setting the IsWorking property to be equal to TestData
            StaffMember.IsWorking = TestData;
            //Checking if IsWorking is equal to the test value
            Assert.AreEqual(StaffMember.IsWorking, TestData);
        }
        [TestMethod]
        public void StartDatePropertyOK()
        {
            clsStaff StaffMember = new clsStaff();
            //Creating test data
            DateTime testData = DateTime.Now.Date;
            //Setting the StartDate property to be equal to testData
            StaffMember.StartDate = testData;
            Assert.AreEqual(StaffMember.StartDate, testData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            //Creating test data
            Int32 testData = 1;
            //Setting the StaffId property to be equal to testData
            Staff.StaffId = testData;
            //Checking they are equal
            Assert.AreEqual(Staff.StaffId, testData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsStaff staff = new clsStaff();
            string testData = "Kacper";
            staff.FirstName = testData;
            Assert.AreEqual(staff.FirstName, testData);
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsStaff staff = new clsStaff();
            string testData = "Bziuk";
            staff.LastName = testData;
            Assert.AreEqual(staff.LastName, testData);
        }
        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            clsStaff staff = new clsStaff();
            string testData = "kacper@mail.com";
            staff.EmailAddress = testData;
            Assert.AreEqual(staff.EmailAddress, testData);
        }
        [TestMethod]
        public void HomeAddressPropertyOK()
        {
            clsStaff staff = new clsStaff();
            string testData = "Newark Street, LE2 1AF";
            staff.HomeAddress = testData;
            Assert.AreEqual(staff.HomeAddress, testData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff staff = new clsStaff();
            //Boolean value to store the results of validation
            Boolean Found = false;
            //test data
            Int32 StaffId = 111;
            //invoking the method
            Found = staff.Find(StaffId);
            //test the result
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 111;
            Found = staff.Find(StaffId);
            if(staff.StaffId != 111)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStartDateFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 111;
            Found = staff.Find(StaffId);
            if (staff.StartDate != Convert.ToDateTime("19/02/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 111;
            Found = staff.Find(StaffId);
            if (staff.FirstName != "Kacper")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 111;
            Found = staff.Find(StaffId);
            if (staff.LastName != "Bziuk")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 111;
            Found = staff.Find(StaffId);
            if (staff.EmailAddress != "kb@mail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestHomeAddressFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 111;
            Found = staff.Find(StaffId);
            if (staff.HomeAddress != "123 Some Ln, LE2 1AB")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsWorkingFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 111;
            Found = staff.Find(StaffId);
            if (staff.IsWorking != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
