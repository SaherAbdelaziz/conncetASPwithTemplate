namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRemovedProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartItems", "Removed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartItems", "Removed");
        }
    }
}
