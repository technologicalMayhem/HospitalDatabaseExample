namespace HospitalDatabaseExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomName = c.String(),
                        Department = c.Int(nullable: false),
                        RoomType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        AssignedRoom_RoomId = c.Int(),
                        MedicalStaff_StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.Rooms", t => t.AssignedRoom_RoomId)
                .ForeignKey("dbo.Staffs", t => t.MedicalStaff_StaffId)
                .Index(t => t.AssignedRoom_RoomId)
                .Index(t => t.MedicalStaff_StaffId);
            
            CreateTable(
                "dbo.PatientRecords",
                c => new
                    {
                        PatientRecordId = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Content = c.String(),
                        Active = c.Boolean(nullable: false),
                        MedicalStaff_StaffId = c.Int(),
                        Patient_PatientId = c.Int(),
                    })
                .PrimaryKey(t => t.PatientRecordId)
                .ForeignKey("dbo.Staffs", t => t.MedicalStaff_StaffId)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId)
                .Index(t => t.MedicalStaff_StaffId)
                .Index(t => t.Patient_PatientId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        InactiveUntil = c.DateTime(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        WorkLocation = c.Int(nullable: false),
                        ShiftStart = c.DateTime(nullable: false),
                        ShiftEnd = c.DateTime(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Room_RoomId = c.Int(),
                    })
                .PrimaryKey(t => t.StaffId)
                .ForeignKey("dbo.Rooms", t => t.Room_RoomId)
                .Index(t => t.Room_RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "Room_RoomId", "dbo.Rooms");
            DropForeignKey("dbo.PatientRecords", "Patient_PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientRecords", "MedicalStaff_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Patients", "MedicalStaff_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Patients", "AssignedRoom_RoomId", "dbo.Rooms");
            DropIndex("dbo.Staffs", new[] { "Room_RoomId" });
            DropIndex("dbo.PatientRecords", new[] { "Patient_PatientId" });
            DropIndex("dbo.PatientRecords", new[] { "MedicalStaff_StaffId" });
            DropIndex("dbo.Patients", new[] { "MedicalStaff_StaffId" });
            DropIndex("dbo.Patients", new[] { "AssignedRoom_RoomId" });
            DropTable("dbo.Staffs");
            DropTable("dbo.PatientRecords");
            DropTable("dbo.Patients");
            DropTable("dbo.Rooms");
        }
    }
}
