namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactorDataBase4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AvailableTable", newName: "AvailableTables");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AvailableTables", newName: "AvailableTable");
        }
    }
}
