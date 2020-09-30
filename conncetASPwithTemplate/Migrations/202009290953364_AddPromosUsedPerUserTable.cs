namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPromosUsedPerUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PromosUsedPerUsers",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        PromoId = c.Int(nullable: false),
                        Count = c.Int(nullable: false , defaultValue:0),
                    })
                .PrimaryKey(t => new { t.UserId, t.PromoId })
                .ForeignKey("dbo.Promoes", t => t.PromoId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.PromoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PromosUsedPerUsers", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.PromosUsedPerUsers", "PromoId", "dbo.Promoes");
            DropIndex("dbo.PromosUsedPerUsers", new[] { "PromoId" });
            DropIndex("dbo.PromosUsedPerUsers", new[] { "UserId" });
            DropTable("dbo.PromosUsedPerUsers");
        }
    }
}
