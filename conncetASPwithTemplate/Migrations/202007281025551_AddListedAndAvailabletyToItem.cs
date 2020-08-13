namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddListedAndAvailabletyToItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "Listed", c => c.Boolean(nullable: false , defaultValue: true));
            AddColumn("dbo.Item", "Available", c => c.Int(nullable: false , defaultValue: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Item", "Available");
            DropColumn("dbo.Item", "Listed");
        }
    }
}
