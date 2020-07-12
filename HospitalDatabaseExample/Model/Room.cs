using System.Collections.Generic;

namespace HospitalDatabaseExample.Model
{
    public class Room
    {
        public string RoomName { get; set; }
        public EnumDepartment Department { get; set; }
        public EnumRoomType RoomType { get; set; }
        public virtual List<Staff> Staff { get; set; }
        public virtual List<Patient> Patients { get; set; }
    }
}