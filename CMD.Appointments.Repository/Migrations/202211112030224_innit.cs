namespace CMD.Appointments.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class innit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        App_Id = c.Long(nullable: false, identity: true),
                        patientId = c.String(nullable: false),
                        doctorId = c.String(nullable: false),
                        Issue = c.String(nullable: false),
                        TimeSlot = c.String(nullable: false),
                        ReasonForVisit = c.String(),
                        Appointment_status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.App_Id);
            
            CreateTable(
                "dbo.prescriptions",
                c => new
                    {
                        Prescription_ID = c.Long(nullable: false, identity: true),
                        Medicine_Name = c.String(nullable: false),
                        Duration = c.String(nullable: false),
                        Medicine_cycle = c.String(nullable: false),
                        Medicine_Description = c.String(nullable: false),
                        IsBeforeFood = c.Boolean(nullable: false),
                        App_Id = c.Long(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Prescription_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.prescriptions");
            DropTable("dbo.Appointments");
        }
    }
}
