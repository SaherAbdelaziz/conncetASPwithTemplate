namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdmin : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Phone], [Adress], [Adress2], [AreaId], [OutletId]) VALUES (N'35399d6c-10fd-4f49-91fc-c116012dd503', N'Admin1@users.com', 0, N'AJRwKLYz5yNOuUBR08MrFXCEeBBgiiPdgoEx8LGJEdVR9jS0n2ZfPzTo3/vbqzs4Sg==', N'08a93c6a-fc96-48ea-91fb-e58d85b70266', NULL, 0, 0, NULL, 1, 0, N'Admin1@users.com', N'Admin1', N'11', N'11', N'11', 1, 1)
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8a53c45b-56c3-4723-a0fa-7b0c95da9d70', N'Manger')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'35399d6c-10fd-4f49-91fc-c116012dd503', N'8a53c45b-56c3-4723-a0fa-7b0c95da9d70')
");
        }
        
        public override void Down()
        {
        }
    }
}
