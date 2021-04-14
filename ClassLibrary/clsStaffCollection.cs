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
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;

            while(Index < RecordCount)
            {
                clsStaff staff = new clsStaff();

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
    }
}