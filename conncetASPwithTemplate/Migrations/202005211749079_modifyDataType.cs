namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyDataType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CartItems");
            AlterColumn("dbo.CartItems", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CartItems", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CartItems");
            AlterColumn("dbo.CartItems", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.CartItems", "Id");
        }
    }
}
