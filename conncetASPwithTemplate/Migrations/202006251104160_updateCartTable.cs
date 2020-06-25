namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCartTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyCartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartId = c.String(),
                        Quantity = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Removed = c.Boolean(nullable: false),
                        Details = c.String(),
                        HasModifiers = c.Boolean(nullable: false),
                        Ordered = c.Boolean(nullable: false),
                        OrderId = c.Int(nullable: false),
                        EldahanItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EldahanItems", t => t.EldahanItemId, cascadeDelete: true)
                .Index(t => t.EldahanItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MyCartItems", "EldahanItemId", "dbo.EldahanItems");
            DropIndex("dbo.MyCartItems", new[] { "EldahanItemId" });
            DropTable("dbo.MyCartItems");
        }
    }
}
