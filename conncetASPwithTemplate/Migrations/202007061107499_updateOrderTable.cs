namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateOrderTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "CartId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "CartId");
            AddForeignKey("dbo.Orders", "CartId", "dbo.Carts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CartId", "dbo.Carts");
            DropIndex("dbo.Orders", new[] { "CartId" });
            AlterColumn("dbo.Orders", "CartId", c => c.String());
        }
    }
}
