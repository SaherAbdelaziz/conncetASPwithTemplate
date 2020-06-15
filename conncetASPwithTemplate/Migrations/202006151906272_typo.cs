namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Details", c => c.String());
            DropColumn("dbo.Orders", "Detials");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Detials", c => c.String());
            DropColumn("dbo.Orders", "Details");
        }
    }
}
