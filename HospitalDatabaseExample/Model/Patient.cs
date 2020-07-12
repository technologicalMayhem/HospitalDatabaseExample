using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalDatabaseExample.Model
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Room AssignedRoom { get; set; }
        public virtual List<PatientRecord> PatientRecords { get; set; }
    }
}