namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWebPresetsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WebPresets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 50),
                        ImagePreset = c.Binary(storeType: "image"),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        UserId = c.Int(),
                        RestIdActive = c.Int(),
                        OutLetIdActive = c.Int(),
                        ByTime = c.Boolean(),
                        StartTime = c.Int(),
                        EndTime = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WebPresets");
        }
    }
}
