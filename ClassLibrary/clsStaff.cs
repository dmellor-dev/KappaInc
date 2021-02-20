using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffId;
        private DateTime mStartDate;
        private string mFirstName;
        private string mLastName;
        private string mEmailAddress;
        private string mHomeAddress;
        private bool mIsWorking;

        public bool IsWorking {
            get
            {
                return mIsWorking;
            }
            set
            {
                mIsWorking = value;
            }
        }
        public DateTime StartDate {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }
        public int StaffId {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }
        public string FirstName {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string LastName {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public string EmailAddress {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }
        public string HomeAddress {
            get
            {
                return mHomeAddress;
            }
            set
            {
                mHomeAddress = value;
            }
        }

        public bool Find(int staffId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", staffId);
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mHomeAddress = Convert.ToString(DB.DataTable.Rows[0]["HomeAddress"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mIsWorking = Convert.ToBoolean(DB.DataTable.Rows[0]["IsWorking"]);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}