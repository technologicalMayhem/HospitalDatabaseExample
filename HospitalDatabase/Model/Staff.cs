using System;

namespace HospitalDatabaseExample.Model
{
    public class Staff
    {
        public int StaffId { get; set; }
        public bool Active { get; set; }
        public DateTime InactiveUntil { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumDepartment WorkLocation { get; set; }
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }
    }
}