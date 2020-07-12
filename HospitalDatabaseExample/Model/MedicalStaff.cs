using System.Collections.Generic;

namespace HospitalDatabaseExample.Model
{
    public class MedicalStaff : Staff
    {
        public virtual List<Patient> AssignedPatients { get; set; }
    }
}