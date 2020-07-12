using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalDatabaseExample.Model
{
    public class PatientRecord
    {
        public virtual Patient Patient { get; set; }
        public virtual MedicalStaff MedicalStaff { get; set; }
        public DateTime Time { get; set; }
        public string Content { get; set; }
        public bool Active { get; set; }
    }
}