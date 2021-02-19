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
            mStaffId = 111;
            mStartDate = Convert.ToDateTime("19/02/2021");
            mFirstName = "Kacper";
            mLastName = "Bziuk";
            mEmailAddress = "kb@mail.com";
            mHomeAddress = "123 Some Ln, LE2 1AB";
            mIsWorking = true;
            return true;
        }
    }
}