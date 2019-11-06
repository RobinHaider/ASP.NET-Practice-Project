namespace Jquery_Data_Table___CSharpCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RollNo = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        FatherName = c.String(nullable: false, maxLength: 50),
                        MotherName = c.String(nullable: false, maxLength: 50),
                        ClassID = c.Int(nullable: false),
                        ReligionID = c.Int(nullable: false),
                        Address = c.String(nullable: false, maxLength: 100),
                        GuardianMobileNumber = c.String(nullable: false),
                        GuardianEmail = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
