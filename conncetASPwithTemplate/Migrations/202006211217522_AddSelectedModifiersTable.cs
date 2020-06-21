namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSelectedModifiersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SelectedModifiers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartId = c.String(),
                        ItemId = c.Int(nullable: false),
                        ItemModifierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemModifierId, cascadeDelete: true)
                .Index(t => t.ItemModifierId);
            
            AddColumn("dbo.CartItems", "HasModifiers", c => c.Boolean(nullable: false));
            AddColumn("dbo.CartItems", "Ordered", c => c.Boolean(nullable: false));
            AddColumn("dbo.CartItems", "OrderId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SelectedModifiers", "ItemModifierId", "dbo.Items");
            DropIndex("dbo.SelectedModifiers", new[] { "ItemModifierId" });
            DropColumn("dbo.CartItems", "OrderId");
            DropColumn("dbo.CartItems", "Ordered");
            DropColumn("dbo.CartItems", "HasModifiers");
            DropTable("dbo.SelectedModifiers");
        }
    }
}
