namespace ManyToManyTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClass1User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUserClass1",
                c => new
                    {
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                        Class1_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ApplicationUser_Id, t.Class1_Id })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id, cascadeDelete: true)
                .ForeignKey("dbo.Class1", t => t.Class1_Id, cascadeDelete: true)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.Class1_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationUserClass1", "Class1_Id", "dbo.Class1");
            DropForeignKey("dbo.ApplicationUserClass1", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ApplicationUserClass1", new[] { "Class1_Id" });
            DropIndex("dbo.ApplicationUserClass1", new[] { "ApplicationUser_Id" });
            DropTable("dbo.ApplicationUserClass1");
        }
    }
}
