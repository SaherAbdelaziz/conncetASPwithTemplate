namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddListedAndAvailabletyToItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EldahanItems", "Listed", c => c.Boolean(nullable: false , defaultValue: true));
            AddColumn("dbo.EldahanItems", "Available", c => c.Int(nullable: false , defaultValue: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EldahanItems", "Available");
            DropColumn("dbo.EldahanItems", "Listed");
        }
    }
}
