using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool IsWorking { get; set; }
        public DateTime StartDate { get; set; }
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
    }
}