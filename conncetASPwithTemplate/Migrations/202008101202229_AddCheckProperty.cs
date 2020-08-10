namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCheckProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CheckId", c => c.Long(nullable: false));
            CreateIndex("dbo.Orders", "CheckId");
            AddForeignKey("dbo.Orders", "CheckId", "dbo.Checks", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CheckId", "dbo.Checks");
            DropIndex("dbo.Orders", new[] { "CheckId" });
            DropColumn("dbo.Orders", "CheckId");
        }
    }
}
