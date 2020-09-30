namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPropertiesToPromos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Promoes", "Name", c => c.String());
            AddColumn("dbo.Promoes", "ExpiryDate", c => c.DateTime(nullable: true));
            AddColumn("dbo.Promoes", "MaxUseingTimes", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Promoes", "MaxUseingTimes");
            DropColumn("dbo.Promoes", "ExpiryDate");
            DropColumn("dbo.Promoes", "Name");
        }
    }
}
