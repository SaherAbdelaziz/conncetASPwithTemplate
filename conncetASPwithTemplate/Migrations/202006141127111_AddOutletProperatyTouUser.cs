namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOutletProperatyTouUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "OutletId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "OutletId");
            AddForeignKey("dbo.AspNetUsers", "OutletId", "dbo.OutLets", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "OutletId", "dbo.OutLets");
            DropIndex("dbo.AspNetUsers", new[] { "OutletId" });
            DropColumn("dbo.AspNetUsers", "OutletId");
        }
    }
}
