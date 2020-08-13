namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactorDataBase3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MyCartItems", newName: "CartItems");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.CartItems", newName: "MyCartItems");
        }
    }
}
