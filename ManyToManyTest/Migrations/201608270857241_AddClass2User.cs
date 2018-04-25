namespace ManyToManyTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClass2User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class2ApplicationUser",
                c => new
                    {
                        Class2_Id = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Class2_Id, t.ApplicationUser_Id })
                .ForeignKey("dbo.Class2", t => t.Class2_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id, cascadeDelete: true)
                .Index(t => t.Class2_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Class2ApplicationUser", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Class2ApplicationUser", "Class2_Id", "dbo.Class2");
            DropIndex("dbo.Class2ApplicationUser", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Class2ApplicationUser", new[] { "Class2_Id" });
            DropTable("dbo.Class2ApplicationUser");
        }
    }
}
