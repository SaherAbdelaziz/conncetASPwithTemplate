namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDetailsUserMessage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderedItems", "Details", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderedItems", "Details");
        }
    }
}
