namespace Internet_Tehnologii_Lab3_222015.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdMig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "Patient_PatientId", "dbo.Patients");
            DropIndex("dbo.Doctors", new[] { "Patient_PatientId" });
            CreateTable(
                "dbo.PatientDoctors",
                c => new
                    {
                        Patient_PatientId = c.Int(nullable: false),
                        Doctor_DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Patient_PatientId, t.Doctor_DoctorId })
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorId, cascadeDelete: true)
                .Index(t => t.Patient_PatientId)
                .Index(t => t.Doctor_DoctorId);
            
            DropColumn("dbo.Doctors", "Patient_PatientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "Patient_PatientId", c => c.Int());
            DropForeignKey("dbo.PatientDoctors", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.PatientDoctors", "Patient_PatientId", "dbo.Patients");
            DropIndex("dbo.PatientDoctors", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.PatientDoctors", new[] { "Patient_PatientId" });
            DropTable("dbo.PatientDoctors");
            CreateIndex("dbo.Doctors", "Patient_PatientId");
            AddForeignKey("dbo.Doctors", "Patient_PatientId", "dbo.Patients", "PatientId");
        }
    }
}
