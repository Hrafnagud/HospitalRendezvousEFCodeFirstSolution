namespace HospitalRendezvousEFCodeFirstDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20211227_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        DoctorName = c.String(nullable: false, maxLength: 50),
                        DoctorSurname = c.String(nullable: false, maxLength: 50),
                        Specialty = c.Byte(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TRID = c.String(nullable: false, maxLength: 11),
                        PhoneNumber = c.String(maxLength: 11),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.DoctorId);
            
            CreateTable(
                "dbo.RendezvousInfoes",
                c => new
                    {
                        RendezvousId = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        RendezvousDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RendezvousId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.DoctorId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        PatientName = c.String(nullable: false, maxLength: 50),
                        PatientSurname = c.String(nullable: false, maxLength: 50),
                        TRID = c.String(nullable: false, maxLength: 11),
                        PhoneNumber = c.String(maxLength: 11),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RendezvousInfoes", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.RendezvousInfoes", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.RendezvousInfoes", new[] { "PatientId" });
            DropIndex("dbo.RendezvousInfoes", new[] { "DoctorId" });
            DropTable("dbo.Patients");
            DropTable("dbo.RendezvousInfoes");
            DropTable("dbo.Doctors");
        }
    }
}
