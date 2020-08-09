namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeUserIdToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Checks", "Cust_ID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Checks", "Cust_ID", c => c.Long());
        }
    }
}
