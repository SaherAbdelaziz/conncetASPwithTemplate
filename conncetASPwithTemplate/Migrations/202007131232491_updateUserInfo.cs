namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUserInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Street", c => c.String());
            AddColumn("dbo.AspNetUsers", "Building", c => c.String());
            AddColumn("dbo.AspNetUsers", "Floor", c => c.String());
            AddColumn("dbo.AspNetUsers", "Apartment", c => c.String());
            AddColumn("dbo.AspNetUsers", "SpecialMark", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SpecialMark");
            DropColumn("dbo.AspNetUsers", "Apartment");
            DropColumn("dbo.AspNetUsers", "Floor");
            DropColumn("dbo.AspNetUsers", "Building");
            DropColumn("dbo.AspNetUsers", "Street");
        }
    }
}
