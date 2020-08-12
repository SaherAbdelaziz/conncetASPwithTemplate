namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrderProperty1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "ApplicationUserId", newName: "AdminId");
            RenameIndex(table: "dbo.Orders", name: "IX_ApplicationUserId", newName: "IX_AdminId");
            AddColumn("dbo.Orders", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Orders", "UserId");
            AddForeignKey("dbo.Orders", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropColumn("dbo.Orders", "UserId");
            RenameIndex(table: "dbo.Orders", name: "IX_AdminId", newName: "IX_ApplicationUserId");
            RenameColumn(table: "dbo.Orders", name: "AdminId", newName: "ApplicationUserId");
        }
    }
}
