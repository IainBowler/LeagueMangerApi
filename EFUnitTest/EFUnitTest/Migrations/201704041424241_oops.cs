namespace EFUnitTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oops : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Children", "Parent_Id", c => c.Int());
            CreateIndex("dbo.Children", "Parent_Id");
            AddForeignKey("dbo.Children", "Parent_Id", "dbo.Parents", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Children", "Parent_Id", "dbo.Parents");
            DropIndex("dbo.Children", new[] { "Parent_Id" });
            DropColumn("dbo.Children", "Parent_Id");
        }
    }
}
