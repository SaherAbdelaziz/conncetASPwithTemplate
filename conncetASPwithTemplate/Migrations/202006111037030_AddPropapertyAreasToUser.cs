namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropapertyAreasToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AreaId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "AreaId");
            AddForeignKey("dbo.AspNetUsers", "AreaId", "dbo.HD_Areas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "AreaId", "dbo.HD_Areas");
            DropIndex("dbo.AspNetUsers", new[] { "AreaId" });
            DropColumn("dbo.AspNetUsers", "AreaId");
        }
    }
}
