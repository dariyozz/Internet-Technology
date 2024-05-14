namespace Internet_Tehnologii_Lab3_222015.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hospitals", "ImageUrl", c => c.String());
            AddColumn("dbo.Patients", "PatientCode", c => c.String(maxLength: 5));
            AlterColumn("dbo.Patients", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Name", c => c.String());
            DropColumn("dbo.Patients", "PatientCode");
            DropColumn("dbo.Hospitals", "ImageUrl");
        }
    }
}
