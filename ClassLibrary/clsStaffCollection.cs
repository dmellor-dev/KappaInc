using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        private List<clsStaff> mStaffList = new List<clsStaff>();
        private clsStaff mThisStaffMember = new clsStaff();
        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
            
        }
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                // TODO
            }
        }
        public clsStaff ThisStaffMember
        {
            get
            {
                return mThisStaffMember;
            }
            set
            {
                mThisStaffMember = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaffMember.StaffId);
            DB.AddParameter("@FirstName", mThisStaffMember.FirstName);
            DB.AddParameter("@LastName", mThisStaffMember.LastName);
            DB.AddParameter("@EmailAddress", mThisStaffMember.EmailAddress);
            DB.AddParameter("@HomeAddress", mThisStaffMember.HomeAddress);
            DB.AddParameter("@StartDate", mThisStaffMember.StartDate);
            DB.AddParameter("@IsWorking", mThisStaffMember.IsWorking);
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaffMember
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaffMember.StaffId);
            DB.AddParameter("@FirstName", mThisStaffMember.FirstName);
            DB.AddParameter("@LastName", mThisStaffMember.LastName);
            DB.AddParameter("@EmailAddress", mThisStaffMember.EmailAddress);
            DB.AddParameter("@HomeAddress", mThisStaffMember.HomeAddress);
            DB.AddParameter("@StartDate", mThisStaffMember.StartDate);
            DB.AddParameter("@IsWorking", mThisStaffMember.IsWorking);
            //executing the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaffMemeber
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaffMember.StaffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByLastName(string LastName)
        {
            // filters the records based on a full or partial last name
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@LastName", LastName);
            DB.Execute("sproc_tblStaff_FilterByLastName");
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff member 
                clsStaff staff = new clsStaff();
                // read in the fields from the current record
                staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                staff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                staff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                staff.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                staff.HomeAddress = Convert.ToString(DB.DataTable.Rows[Index]["HomeAddress"]);
                staff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                staff.IsWorking = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsWorking"]);

                mStaffList.Add(staff);
                Index++;
            }
        }
    }
}