﻿using System.Collections.Generic;
using System.Data.Entity;

namespace HospitalDatabaseExample.Model
{
    public class HospitalContext : DbContext
    {
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Room> PatientRooms { get; set; }
    }
}