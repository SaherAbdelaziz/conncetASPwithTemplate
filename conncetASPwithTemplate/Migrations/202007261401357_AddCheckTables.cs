namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCheckTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checks",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        CheckSerail = c.Int(nullable: false),
                        CheckTitel = c.String(maxLength: 50),
                        CheckType = c.String(maxLength: 50),
                        Covers = c.Int(),
                        MyTable = c.String(maxLength: 50),
                        MyStatus = c.String(maxLength: 50),
                        Splited = c.Boolean(),
                        RefranceTo = c.Long(),
                        myDateTime = c.DateTime(),
                        OpenIn = c.DateTime(),
                        ClosedIn = c.DateTime(),
                        Cust_ID = c.Long(),
                        Server_ID = c.Int(),
                        Casher_ID = c.Int(),
                        Admin_ID = c.Int(),
                        OutLet_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        WS = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        Num_Fired = c.Int(),
                        User_ID = c.Int(),
                        Voided = c.Boolean(),
                        Voided_Time = c.DateTime(),
                        Voided_Reason = c.Int(),
                        Order_No = c.Int(),
                        ReOpen = c.Boolean(),
                        Table_ID = c.Int(),
                        Num_Print = c.Int(),
                        Lvl_Split = c.Int(),
                        ChangeAfterSplit = c.Int(),
                        Combined = c.Boolean(),
                        Combined_To = c.Long(),
                        ChangeAfterCombine = c.Int(),
                        Received = c.Boolean(),
                        Received_Time = c.DateTime(),
                        Point_ID = c.Int(),
                        Meal_ID = c.Int(),
                        Voided_By = c.Int(),
                        Catering_ID = c.Long(),
                        Pick_Up = c.Boolean(),
                        Pick_Up_Time = c.DateTime(),
                        Officer = c.Boolean(),
                        Officer_ID = c.Int(),
                        Void_Reason_Comment = c.String(maxLength: 100),
                        Call_Center = c.Boolean(),
                        PrePaid_Card = c.Boolean(),
                        PrePaid_Serial = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ChecksItems",
                c => new
                    {
                        Check_ID = c.Long(nullable: false),
                        Serial = c.Int(nullable: false),
                        Item_ID = c.Int(),
                        QTY = c.Single(),
                        UnitPrice = c.Double(),
                        TotalPrice = c.Double(),
                        DicountValue = c.Double(),
                        Tax_Value = c.Double(),
                        Adj_Value = c.Double(),
                        NetPrice = c.Double(),
                        Fired = c.Boolean(),
                        Fired_Time = c.DateTime(),
                        Voided = c.Boolean(),
                        Voided_Time = c.DateTime(),
                        Voided_Reason = c.Int(),
                        P_On_Check = c.Boolean(),
                        Complement = c.Double(),
                        Status = c.String(maxLength: 50),
                        IsModifier = c.Boolean(),
                        Ref_Mod_Item = c.Int(),
                        IsAssimbly = c.Boolean(),
                        Ref_Ass_Item = c.Int(),
                        Taxable = c.Boolean(),
                        NoServiceCharge = c.Boolean(),
                        Num_Fired = c.Int(),
                        Num_Print = c.Int(),
                        Server_ID = c.Int(),
                        P_On_Report = c.Boolean(),
                        Check_ID_Combine = c.Long(),
                        Round_Check_Fired = c.Int(),
                        Void_Effect_Invn = c.Boolean(),
                        Promo_ID = c.Int(),
                        Orig_Price = c.Double(),
                        Officer = c.Double(),
                        Comp_Reason_ID = c.Int(),
                        End_Serial_Count = c.Long(),
                        Discount_ID = c.Int(),
                        Disc_Reason_ID = c.Int(),
                        Hold = c.Boolean(),
                        Hold_Time = c.DateTime(),
                        Voided_By = c.Int(),
                        Comp_By = c.Int(),
                        Disc_By = c.Int(),
                        Preparation_Time = c.Int(),
                        Disc_Reason_Comment = c.String(maxLength: 100),
                        Comp_Reason_Comment = c.String(maxLength: 100),
                        Void_Reason_Comment = c.String(maxLength: 100),
                        ModifierGroup_ID = c.Int(),
                        Pick_Follow_Item_Qty = c.Boolean(),
                        Modifier_Pick = c.Int(),
                        Pre_Paid_Card = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.Check_ID, t.Serial });
            
            CreateTable(
                "dbo.ChecksItemsSettlesSummary",
                c => new
                    {
                        Check_ID = c.Long(nullable: false),
                        Voided = c.Boolean(nullable: false),
                        SubTotal = c.Double(),
                        Taxes = c.Double(),
                        VoidTaxes = c.Boolean(),
                        Adjustments = c.Double(),
                        VoidAdjustments = c.Boolean(),
                        Discount = c.Double(),
                        ChangeValue = c.Double(),
                        R_MinCharge = c.Double(),
                        VoidR_MinCharge = c.Boolean(),
                        NetTotal = c.Double(),
                        Tip = c.Double(),
                        TotalAmount = c.Double(),
                        TotalPaid = c.Double(),
                        RiminingAmount = c.Double(),
                        MinCharge = c.Double(),
                        Discount_ID = c.Int(),
                        MOP_ID = c.Int(),
                        Disc_Reason_ID = c.Int(),
                        Disc_By = c.Int(),
                        Set_MinCharge_One_Cover = c.Double(),
                        Disc_Reason_Comment = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.Check_ID, t.Voided });
            
            CreateTable(
                "dbo.ChecksTaxAdjTip",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Check_ID = c.Long(),
                        AdjTax_ID = c.Int(),
                        Perc_AdjTax = c.Double(),
                        Value_AdjTax = c.Double(),
                        theCase = c.String(maxLength: 50),
                        Voided = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChecksTaxAdjTip");
            DropTable("dbo.ChecksItemsSettlesSummary");
            DropTable("dbo.ChecksItems");
            DropTable("dbo.Checks");
        }
    }
}
