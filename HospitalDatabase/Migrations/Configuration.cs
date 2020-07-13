
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace HospitalDatabaseExample.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<HospitalDatabaseExample.Model.HospitalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}