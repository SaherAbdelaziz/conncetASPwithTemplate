namespace conncetASPwithTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOthersDatabaseTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adjustments",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        type = c.String(maxLength: 50),
                        Value = c.Double(),
                        MinimumPersonesToCalculate = c.Int(),
                        Timed = c.Boolean(),
                        tFrom = c.String(maxLength: 50),
                        tTo = c.String(maxLength: 50),
                        Taxable = c.Boolean(),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        SetDefault = c.Boolean(),
                        OpenAmount = c.Boolean(),
                        For_Each_Cover = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Aging",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Days = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AR_Checks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeAR = c.String(maxLength: 50),
                        Check_ID = c.Long(),
                        Cust_ID = c.Long(),
                        Cashier_Credit = c.Int(),
                        GuestName = c.String(maxLength: 500),
                        myDate = c.DateTime(),
                        TotalAmount = c.Double(),
                        TotalPaid = c.Double(),
                        RiminingAmount = c.Double(),
                        Paid = c.String(maxLength: 50),
                        Voided = c.Boolean(),
                        Voided_Reason = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        OutLet_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AR_Checks_Pay",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Cust_ID = c.Long(),
                        Amt = c.Double(),
                        AR_ID = c.String(),
                        Voided = c.Boolean(),
                        Voided_Reason = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        OutLet_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AR_Customers",
                c => new
                    {
                        Cust_ID = c.Long(nullable: false),
                        AR_Value = c.Double(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.Cust_ID);
            
            CreateTable(
                "dbo.Assign_Drawer",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Log_ID = c.Int(nullable: false),
                        User_ID = c.Int(),
                        Drawer_ID = c.Int(),
                        Status = c.String(maxLength: 50),
                        Open_Date = c.DateTime(),
                        Close_Date = c.DateTime(),
                        Open_Amt = c.Double(),
                        Close_Amt = c.Double(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AvailableTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WS = c.Int(),
                        ComputerIP = c.String(nullable: false, maxLength: 50),
                        ComputerName = c.String(nullable: false, maxLength: 50),
                        TableLock = c.String(maxLength: 50),
                        DateLock = c.DateTime(),
                        IDRow = c.String(maxLength: 50),
                        FormLock = c.String(maxLength: 50),
                        State = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cash_Drawer",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        OutLet_ID_Active = c.Int(),
                        Printer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cat_Checks",
                c => new
                    {
                        CheckSerail = c.Int(nullable: false),
                        CheckTitel = c.String(maxLength: 50),
                        CheckType = c.String(maxLength: 50),
                        Covers = c.Int(),
                        myTable = c.String(maxLength: 50),
                        ServerCode = c.Int(),
                        OutletCode = c.Int(),
                        myCase = c.String(maxLength: 50),
                        myStatus = c.String(maxLength: 50),
                        RefranceTo = c.Int(),
                        PeriodCode = c.Int(),
                        myDateTime = c.DateTime(),
                        OpenIn = c.String(maxLength: 50),
                        ClosedIn = c.String(maxLength: 50),
                        CasherCode = c.Int(),
                        Option1 = c.String(maxLength: 50),
                        Option2 = c.String(maxLength: 50),
                        Option3 = c.String(maxLength: 50),
                        Option4 = c.String(maxLength: 50),
                        Option5 = c.String(maxLength: 50),
                        Option6 = c.String(maxLength: 50),
                        Option7 = c.String(maxLength: 50),
                        Option8 = c.String(maxLength: 50),
                        Option9 = c.String(maxLength: 50),
                        Option10 = c.String(maxLength: 50),
                        Col1 = c.String(maxLength: 50),
                        Col2 = c.String(maxLength: 50),
                        Col3 = c.String(maxLength: 50),
                        Col4 = c.String(maxLength: 50),
                        Col5 = c.String(maxLength: 50),
                        Col6 = c.String(maxLength: 50),
                        Col7 = c.String(maxLength: 50),
                        Col8 = c.String(maxLength: 50),
                        Col9 = c.String(maxLength: 50),
                        Col10 = c.String(maxLength: 50),
                        CustCode = c.Int(),
                        Code1 = c.Int(),
                        Code2 = c.Int(),
                        Code3 = c.Int(),
                        Code4 = c.Int(),
                        Code5 = c.Int(),
                    })
                .PrimaryKey(t => t.CheckSerail);
            
            CreateTable(
                "dbo.Cat_ChecksItems",
                c => new
                    {
                        RtfSerial = c.Int(nullable: false),
                        CheckCode = c.Int(),
                        ItemCode = c.Int(),
                        UnitPrice = c.String(maxLength: 50),
                        QTY = c.Single(),
                        TotalPrice = c.String(maxLength: 50),
                        PeriodCode = c.Int(),
                        myCase = c.String(maxLength: 50),
                        RefranceCode = c.Int(),
                        DicountValue = c.String(maxLength: 50),
                        Col1 = c.String(maxLength: 50),
                        Col2 = c.String(maxLength: 50),
                        Col3 = c.String(maxLength: 50),
                        Col4 = c.String(maxLength: 50),
                        Col5 = c.String(maxLength: 50),
                        Col6 = c.String(maxLength: 50),
                        Col7 = c.String(maxLength: 50),
                        Col8 = c.String(maxLength: 50),
                        Col9 = c.String(maxLength: 50),
                        Col10 = c.String(maxLength: 50),
                        OutletCode = c.Int(),
                        CheckType = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RtfSerial);
            
            CreateTable(
                "dbo.Cat_histChecks",
                c => new
                    {
                        CheckSerail = c.Int(nullable: false),
                        CheckTitel = c.String(maxLength: 50),
                        CheckType = c.String(maxLength: 50),
                        Covers = c.Int(),
                        myTable = c.String(maxLength: 50),
                        ServerCode = c.Int(),
                        OutletCode = c.Int(),
                        myCase = c.String(maxLength: 50),
                        myStatus = c.String(maxLength: 50),
                        RefranceTo = c.Int(),
                        PeriodCode = c.Int(),
                        myDateTime = c.DateTime(),
                        OpenIn = c.String(maxLength: 50),
                        ClosedIn = c.String(maxLength: 50),
                        CasherCode = c.Int(),
                        Option1 = c.String(maxLength: 50),
                        Option2 = c.String(maxLength: 50),
                        Option3 = c.String(maxLength: 50),
                        Option4 = c.String(maxLength: 50),
                        Option5 = c.String(maxLength: 50),
                        Option6 = c.String(maxLength: 50),
                        Option7 = c.String(maxLength: 50),
                        Option8 = c.String(maxLength: 50),
                        Option9 = c.String(maxLength: 50),
                        Option10 = c.String(maxLength: 50),
                        Col1 = c.String(maxLength: 50),
                        Col2 = c.String(maxLength: 50),
                        Col3 = c.String(maxLength: 50),
                        Col4 = c.String(maxLength: 50),
                        Col5 = c.String(maxLength: 50),
                        Col6 = c.String(maxLength: 50),
                        Col7 = c.String(maxLength: 50),
                        Col8 = c.String(maxLength: 50),
                        Col9 = c.String(maxLength: 50),
                        Col10 = c.String(maxLength: 50),
                        CustCode = c.Int(),
                        Code1 = c.Int(),
                        Code2 = c.Int(),
                        Code3 = c.Int(),
                        Code4 = c.Int(),
                        Code5 = c.Int(),
                    })
                .PrimaryKey(t => t.CheckSerail);
            
            CreateTable(
                "dbo.Cat_histChecksItems",
                c => new
                    {
                        RtfSerial = c.Int(nullable: false),
                        CheckCode = c.Int(),
                        ItemCode = c.Int(),
                        UnitPrice = c.String(maxLength: 50),
                        QTY = c.Single(),
                        TotalPrice = c.String(maxLength: 50),
                        PeriodCode = c.Int(),
                        myCase = c.String(maxLength: 50),
                        RefranceCode = c.Int(),
                        DicountValue = c.String(maxLength: 50),
                        Col1 = c.String(maxLength: 50),
                        Col2 = c.String(maxLength: 50),
                        Col3 = c.String(maxLength: 50),
                        Col4 = c.String(maxLength: 50),
                        Col5 = c.String(maxLength: 50),
                        Col6 = c.String(maxLength: 50),
                        Col7 = c.String(maxLength: 50),
                        Col8 = c.String(maxLength: 50),
                        Col9 = c.String(maxLength: 50),
                        Col10 = c.String(maxLength: 50),
                        OutletCode = c.Int(),
                        CheckType = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RtfSerial);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Catering",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        Serial = c.Int(),
                        Check_ID = c.Long(),
                        Cust_ID = c.Long(),
                        Status = c.String(maxLength: 50),
                        Type_Catering = c.String(maxLength: 50),
                        Catering_Date = c.DateTime(),
                        Receive_Date = c.DateTime(),
                        Voided = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        OutLet_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        WS = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Change_Server",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Check_ID = c.Long(),
                        Old_Server_ID = c.Int(),
                        New_Server_ID = c.Int(),
                        CreateDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ChecksCompleted",
                c => new
                    {
                        Check_ID = c.Long(nullable: false),
                        Round_Check_Fired = c.Int(nullable: false),
                        Completed = c.Boolean(),
                        Completed_Time = c.DateTime(),
                        Voided = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.Check_ID, t.Round_Check_Fired });
            
            CreateTable(
                "dbo.ChecksItemsCompleted",
                c => new
                    {
                        Check_ID = c.Long(nullable: false),
                        Serial = c.Int(nullable: false),
                        Ref_Mod_Item = c.Int(),
                        Completed = c.Boolean(),
                        Completed_Time = c.DateTime(),
                        Voided = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.Check_ID, t.Serial });
            
            CreateTable(
                "dbo.ChecksItemsSerials",
                c => new
                    {
                        Check_ID = c.Long(nullable: false),
                        Serial = c.Int(nullable: false),
                        PrePaid_Serial = c.String(nullable: false, maxLength: 20),
                        Item_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.Check_ID, t.Serial, t.PrePaid_Serial });
            
            CreateTable(
                "dbo.ChecksItemsSettles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Check_ID = c.Long(nullable: false),
                        MOP_ID = c.Int(),
                        theValue = c.Double(),
                        Serials = c.String(maxLength: 50),
                        EpirDate = c.DateTime(),
                        Officer_ID = c.Int(),
                        Voided = c.Boolean(),
                        Voided_Reason = c.Int(),
                        Voided_By = c.Int(),
                        CL_ID = c.Int(),
                        Batch_No = c.Int(),
                        Void_Reason_Comment = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CL",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 100),
                        Dept_ID = c.Int(),
                        Notes = c.String(maxLength: 250),
                        Allow_Balance_Month = c.Double(),
                        begin_Month = c.Int(),
                        Block = c.Boolean(),
                        Reason_Block = c.String(maxLength: 250),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        Discount_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Complementary_Reasons",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Convert_Points",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Points = c.Int(),
                        Amt = c.Double(),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Currency_Rate",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Rate = c.Double(),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customer_Points",
                c => new
                    {
                        Cust_ID = c.Long(nullable: false),
                        Point_ID = c.Int(nullable: false),
                        Check_ID = c.Long(nullable: false),
                        Points = c.Int(),
                        Used = c.Int(),
                        Expiry_Date = c.DateTime(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Voided = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.Cust_ID, t.Point_ID, t.Check_ID });
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 100),
                        Adress = c.String(maxLength: 300),
                        Adress2 = c.String(maxLength: 300),
                        Company_ID = c.Int(),
                        Area_ID = c.Int(),
                        Street = c.String(maxLength: 100),
                        From_Street = c.String(maxLength: 100),
                        Building = c.String(maxLength: 50),
                        Floor = c.String(maxLength: 50),
                        apartment = c.String(maxLength: 50),
                        Special_Mark = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100),
                        AR = c.Boolean(),
                        CreditLimit = c.Double(),
                        FrequentGust = c.Boolean(),
                        AcceptLatePayments = c.Boolean(),
                        Discount_ID = c.Int(),
                        Block = c.Boolean(),
                        Reason_Block = c.String(maxLength: 250),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        AR_No = c.String(maxLength: 50),
                        Signature = c.Binary(storeType: "image"),
                        Notes = c.String(maxLength: 250),
                        PassCode = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers_Telephone",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cust_ID = c.Long(nullable: false),
                        Phone = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Design_DiningRooms",
                c => new
                    {
                        DiningRoom_ID = c.Int(nullable: false),
                        Height = c.Int(),
                        Width = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.DiningRoom_ID);
            
            CreateTable(
                "dbo.Design_DiningRooms_Tables",
                c => new
                    {
                        Design_ID = c.Int(nullable: false),
                        Table_ID = c.Int(nullable: false),
                        Field_Font = c.String(maxLength: 100),
                        Field_Location = c.String(maxLength: 100),
                        Field_Size = c.String(maxLength: 100),
                        Serial = c.Int(),
                    })
                .PrimaryKey(t => new { t.Design_ID, t.Table_ID });
            
            CreateTable(
                "dbo.DiningRooms",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        OutLet_ID_Active = c.Int(),
                        Image_Room = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Disable_Table",
                c => new
                    {
                        Table_ID = c.Int(nullable: false),
                        CreateDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Table_ID);
            
            CreateTable(
                "dbo.Discount_Reasons",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        DiscountStauts = c.String(maxLength: 50),
                        DisValue = c.Double(),
                        Catrgories = c.Boolean(),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        Manager = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DiscountsCatrgories",
                c => new
                    {
                        Discount_ID = c.Int(nullable: false),
                        Category_ID = c.Int(nullable: false),
                        ValueDis = c.Double(),
                    })
                .PrimaryKey(t => new { t.Discount_ID, t.Category_ID });
            
            CreateTable(
                "dbo.dtproperties",
                c => new
                    {
                        id = c.Int(nullable: false),
                        property = c.String(nullable: false, maxLength: 64),
                        objectid = c.Int(),
                        value = c.String(maxLength: 255),
                        uvalue = c.String(maxLength: 255),
                        lvalue = c.Binary(storeType: "image"),
                        version = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.id, t.property });
            
            CreateTable(
                "dbo.End_Shift_User",
                c => new
                    {
                        Log_ID = c.Int(nullable: false),
                        User_Type = c.String(nullable: false, maxLength: 50),
                        Rest_ID_Active = c.Int(nullable: false),
                        Checks_Count = c.Int(),
                        Items_Count = c.Int(),
                        Void_Checks_Count = c.Int(),
                        Void_Checks_Value = c.Double(),
                        Void_Items_Count = c.Int(),
                        Void_Items_Value = c.Double(),
                        SubTotal = c.Double(),
                        Adjustments = c.Double(),
                        Taxes = c.Double(),
                        Discount = c.Double(),
                        R_MinCharge = c.Double(),
                        NetTotal = c.Double(),
                        Tip = c.Double(),
                        TotalAmount = c.Double(),
                        Checks_ID = c.String(nullable: false),
                        Open_Drawer = c.Double(),
                        Apply_Payment = c.Double(),
                        PaidOut = c.Double(),
                    })
                .PrimaryKey(t => new { t.Log_ID, t.User_Type, t.Rest_ID_Active });
            
            CreateTable(
                "dbo.FC_Adjust_Items",
                c => new
                    {
                        Adj_ID = c.Long(nullable: false),
                        FC_Item_ID = c.Int(nullable: false),
                        FC_Recipe_ID = c.Int(nullable: false),
                        Qty_OnHand = c.Double(),
                        Qty_Adj = c.Double(),
                        Qty = c.Double(),
                        Unit_ID = c.Int(),
                        Cost = c.Double(),
                        Comment = c.String(maxLength: 200),
                        Serial = c.Int(),
                    })
                .PrimaryKey(t => new { t.Adj_ID, t.FC_Item_ID, t.FC_Recipe_ID });
            
            CreateTable(
                "dbo.FC_Adjust_Reason",
                c => new
                    {
                        Adj_Reason_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Adj_Reason_ID);
            
            CreateTable(
                "dbo.FC_Adjustment",
                c => new
                    {
                        Adj_ID = c.Long(nullable: false),
                        Adj_No = c.Int(nullable: false),
                        Status = c.String(maxLength: 50),
                        Source_Type = c.String(maxLength: 50),
                        Adj_Date = c.DateTime(),
                        Adj_Reason_ID = c.Int(),
                        Variance_ID = c.Long(),
                        Comment = c.String(maxLength: 500),
                        Post = c.Boolean(),
                        PostedDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Invn_ID = c.Int(),
                        Invn_Kit_ID = c.Int(),
                        WS = c.Int(),
                    })
                .PrimaryKey(t => t.Adj_ID);
            
            CreateTable(
                "dbo.FC_Bulk_Items",
                c => new
                    {
                        Bulk_Item_ID = c.Int(nullable: false),
                        Yeld_Perc = c.Double(),
                        Active = c.Boolean(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Bulk_Item_ID);
            
            CreateTable(
                "dbo.FC_Bulk_Items_Child",
                c => new
                    {
                        Bulk_Item_ID = c.Int(nullable: false),
                        FC_Item_ID = c.Int(nullable: false),
                        Perc_Qty = c.Double(),
                        Perc_Cost = c.Double(),
                        Serial = c.Int(),
                    })
                .PrimaryKey(t => new { t.Bulk_Item_ID, t.FC_Item_ID });
            
            CreateTable(
                "dbo.FC_Categories",
                c => new
                    {
                        Cat_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Cat_Type = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Cat_ID);
            
            CreateTable(
                "dbo.FC_Convert_Units",
                c => new
                    {
                        L_Unit_ID = c.Int(nullable: false),
                        S_Unit_ID = c.Int(nullable: false),
                        Qty = c.Double(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.L_Unit_ID, t.S_Unit_ID });
            
            CreateTable(
                "dbo.FC_Inventory",
                c => new
                    {
                        Invn_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 150),
                        Name2 = c.String(maxLength: 150),
                        Active = c.Boolean(),
                        Main_Invn = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Invn_ID);
            
            CreateTable(
                "dbo.FC_Invn_kit_Sheet",
                c => new
                    {
                        Sheet_ID = c.Long(nullable: false),
                        Sheet_No = c.Int(),
                        Status = c.String(maxLength: 50),
                        Invn_ID = c.Int(),
                        Invn_Kit_ID = c.Int(),
                        Used = c.Boolean(),
                        Closed = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        WS = c.Int(),
                    })
                .PrimaryKey(t => t.Sheet_ID);
            
            CreateTable(
                "dbo.FC_Invn_kit_Sheet_Items",
                c => new
                    {
                        Sheet_ID = c.Long(nullable: false),
                        FC_Item_ID = c.Int(nullable: false),
                        FC_Recipe_ID = c.Int(nullable: false),
                        Qty_OnHand = c.Double(),
                        Unit_ID = c.Int(),
                        Cost = c.Double(),
                        Serial = c.Int(),
                    })
                .PrimaryKey(t => new { t.Sheet_ID, t.FC_Item_ID, t.FC_Recipe_ID });
            
            CreateTable(
                "dbo.FC_Invn_kit_Variance",
                c => new
                    {
                        Variance_ID = c.Long(nullable: false),
                        Variance_No = c.Int(),
                        Adj_Reason_ID = c.Int(),
                        Variance_Date = c.DateTime(),
                        Sheet_ID = c.Long(nullable: false),
                        Invn_ID = c.Int(),
                        Invn_Kit_ID = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        WS = c.Int(),
                    })
                .PrimaryKey(t => t.Variance_ID);
            
            CreateTable(
                "dbo.FC_Invn_kit_Variance_Items",
                c => new
                    {
                        Variance_ID = c.Long(nullable: false),
                        FC_Item_ID = c.Int(nullable: false),
                        FC_Recipe_ID = c.Int(nullable: false),
                        Qty_OnHand = c.Double(),
                        Qty_Count = c.Double(),
                        Qty_Variance = c.Double(),
                        Unit_ID = c.Int(),
                        Cost = c.Double(),
                        Serial = c.Int(),
                    })
                .PrimaryKey(t => new { t.Variance_ID, t.FC_Item_ID, t.FC_Recipe_ID });
            
            CreateTable(
                "dbo.FC_Invn_Kitchen",
                c => new
                    {
                        Invn_Kit_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 150),
                        Name2 = c.String(maxLength: 150),
                        Invn_ID = c.Int(),
                        Active = c.Boolean(),
                        Main_kit = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Is_OutLet = c.Boolean(),
                    })
                .PrimaryKey(t => t.Invn_Kit_ID);
            
            CreateTable(
                "dbo.FC_Item_Cost",
                c => new
                    {
                        FC_Item_ID = c.Int(nullable: false),
                        FC_Recipe_ID = c.Int(nullable: false),
                        Invn_ID = c.Int(nullable: false),
                        Unit_ID = c.Int(nullable: false),
                        AV_Cost = c.Double(),
                    })
                .PrimaryKey(t => new { t.FC_Item_ID, t.FC_Recipe_ID, t.Invn_ID, t.Unit_ID });
            
            CreateTable(
                "dbo.FC_Item_Invn_Qty",
                c => new
                    {
                        FC_Item_ID = c.Int(nullable: false),
                        FC_Recipe_ID = c.Int(nullable: false),
                        Invn_Kit_ID = c.Int(nullable: false),
                        Invn_ID = c.Int(nullable: false),
                        Unit_ID = c.Int(nullable: false),
                        Qty = c.Double(),
                    })
                .PrimaryKey(t => new { t.FC_Item_ID, t.FC_Recipe_ID, t.Invn_Kit_ID, t.Invn_ID, t.Unit_ID });
            
            CreateTable(
                "dbo.FC_Items",
                c => new
                    {
                        FC_Item_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Cross_Code = c.String(maxLength: 50),
                        Name = c.String(maxLength: 150),
                        Name2 = c.String(maxLength: 150),
                        BarCode = c.String(maxLength: 30),
                        Cat_ID = c.Int(),
                        SCat_ID = c.Int(),
                        Cost = c.Double(),
                        Unit_ID = c.Int(),
                        Using_Unit_ID = c.Int(),
                        Pur_Unit_ID = c.Int(),
                        Parent_Item = c.Boolean(),
                        Bulk_Item = c.Boolean(),
                        Hot_Item = c.Boolean(),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.FC_Item_ID);
            
            CreateTable(
                "dbo.FC_Items_For_Invn_Kit",
                c => new
                    {
                        FC_Item_ID = c.Int(nullable: false),
                        FC_Recipe_ID = c.Int(nullable: false),
                        Invn_Kit_ID = c.Int(nullable: false),
                        Invn_ID = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.FC_Item_ID, t.FC_Recipe_ID, t.Invn_Kit_ID, t.Invn_ID });
            
            CreateTable(
                "dbo.FC_ItemsChild",
                c => new
                    {
                        FC_Item_ID = c.Int(nullable: false),
                        Child_FC_Item_ID = c.Int(nullable: false),
                        Serial = c.Int(),
                    })
                .PrimaryKey(t => new { t.FC_Item_ID, t.Child_FC_Item_ID });
            
            CreateTable(
                "dbo.FC_Kitchen_Outlets",
                c => new
                    {
                        OutLet_ID = c.Int(nullable: false),
                        Invn_Kit_ID = c.Int(nullable: false),
                        Order_By = c.Int(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.OutLet_ID, t.Invn_Kit_ID });
            
            CreateTable(
                "dbo.FC_Process_BI",
                c => new
                    {
                        Process_BI_ID = c.Long(nullable: false),
                        Process_No = c.Int(),
                        Process_Date = c.DateTime(),
                        Invn_ID = c.Int(),
                        Invn_Kit_ID = c.Int(),
                        Bulk_Item_ID = c.Int(),
                        OnHand = c.Double(),
                        Process_Qty = c.Double(),
                        Unit_ID = c.Int(),
                        Cost = c.Double(),
                        Yeld_Perc = c.Double(),
                        Notes = c.String(maxLength: 1000),
                        CreateDate = c.DateTime(),
                        User_ID = c.Int(),
                        Status = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Process_BI_ID);
            
            CreateTable(
                "dbo.FC_Process_BI_Child",
                c => new
                    {
                        Process_BI_ID = c.Long(nullable: false),
                        FC_Item_ID = c.Int(nullable: false),
                        Perc_Qty = c.Double(),
                        ProcessQty = c.Double(),
                        Perc_Cost = c.Double(),
                        UpdateCost = c.Double(),
                        Serial = c.Int(),
                    })
                .PrimaryKey(t => new { t.Process_BI_ID, t.FC_Item_ID });
            
            CreateTable(
                "dbo.FC_Produce_Rcp_Child",
                c => new
                    {
                        Produce_Rcp_ID = c.Long(nullable: false),
                        FC_Item_ID = c.Int(nullable: false),
                        FC_Sub_Recipe_ID = c.Int(nullable: false),
                        Qty = c.Double(),
                        Unit_ID = c.Int(),
                        Cost = c.Double(),
                        Total_Cost = c.Double(),
                        Cost_Perc = c.Double(),
                        Serial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Produce_Rcp_ID, t.FC_Item_ID, t.FC_Sub_Recipe_ID });
            
            CreateTable(
                "dbo.FC_Produce_Recipe",
                c => new
                    {
                        Produce_Rcp_ID = c.Long(nullable: false),
                        Produce_No = c.Int(),
                        Produce_Date = c.DateTime(),
                        Invn_ID = c.Int(),
                        Invn_Kit_ID = c.Int(),
                        FC_Recipe_ID = c.Int(),
                        Produce_Qty = c.Double(),
                        Unit_ID = c.Int(),
                        TotalCost = c.Double(),
                        Notes = c.String(maxLength: 1000),
                        CreateDate = c.DateTime(),
                        User_ID = c.Int(),
                        Status = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Produce_Rcp_ID);
            
            CreateTable(
                "dbo.FC_ReceivdData",
                c => new
                    {
                        ID_Auto = c.Int(nullable: false, identity: true),
                        Check_ID = c.Long(),
                        Check_Serial = c.Int(),
                        CreateDate = c.DateTime(),
                        MyDate = c.DateTime(),
                        Cross_Code = c.String(maxLength: 50),
                        Qty = c.Double(),
                        Posted = c.Boolean(),
                        DatePost = c.DateTime(),
                        OutLet_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Auto);
            
            CreateTable(
                "dbo.FC_Recipe_Items",
                c => new
                    {
                        FC_Recipe_ID = c.Int(nullable: false),
                        FC_Item_ID = c.Int(nullable: false),
                        FC_Sub_Recipe_ID = c.Int(nullable: false),
                        Qty = c.Double(),
                        Unit_ID = c.Int(),
                        Cost = c.Double(),
                        Total_Cost = c.Double(),
                        Cost_Perc = c.Double(),
                        Serial = c.Int(),
                        Packing_List = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.FC_Recipe_ID, t.FC_Item_ID, t.FC_Sub_Recipe_ID });
            
            CreateTable(
                "dbo.FC_Recipes",
                c => new
                    {
                        FC_Recipe_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Cross_Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 150),
                        Name2 = c.String(maxLength: 150),
                        Cat_ID = c.Int(),
                        SCat_ID = c.Int(),
                        Qty = c.Double(),
                        Unit_ID = c.Int(),
                        Cost = c.Double(),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.FC_Recipe_ID);
            
            CreateTable(
                "dbo.FC_Setup",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Calc_Cost_AVERAGE = c.Boolean(),
                        Calc_Cost_Last_Cost = c.Boolean(),
                        Calc_Cost_FIFO = c.Boolean(),
                        Calc_Cost_LIFO = c.Boolean(),
                        Deductive_POS_Data_Negative = c.Boolean(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Invn_Kit = c.Boolean(),
                        Invn_Only = c.Boolean(),
                        Kit_Only = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FC_SubCategories",
                c => new
                    {
                        SCat_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Cat_ID = c.Int(),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.SCat_ID);
            
            CreateTable(
                "dbo.FC_Transfer",
                c => new
                    {
                        Tran_ID = c.Long(nullable: false),
                        Tran_No = c.Int(),
                        Tran_Type = c.String(maxLength: 50),
                        Status = c.String(maxLength: 50),
                        Tran_Date = c.DateTime(),
                        ReceivedDate = c.DateTime(),
                        Received = c.Boolean(),
                        From_Invn_ID = c.Int(),
                        From_Invn_Kit_ID = c.Int(),
                        To_Invn_ID = c.Int(),
                        To_Invn_Kit_ID = c.Int(),
                        Iss_ID = c.Long(),
                        Return_Tran_ID = c.Long(),
                        Comment = c.String(maxLength: 500),
                        Post = c.Boolean(),
                        PostedDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Received_UserID = c.Int(),
                        WS = c.Int(),
                    })
                .PrimaryKey(t => t.Tran_ID);
            
            CreateTable(
                "dbo.FC_Transfer_Items",
                c => new
                    {
                        Tran_ID = c.Long(nullable: false),
                        FC_Item_ID = c.Int(nullable: false),
                        FC_Recipe_ID = c.Int(nullable: false),
                        QtyIss = c.Double(),
                        QtyOnHand = c.Double(),
                        QtySent = c.Double(),
                        QtyRec = c.Double(),
                        Unit_ID = c.Int(),
                        Cost = c.Double(),
                        Comment = c.String(maxLength: 200),
                        Serial = c.Int(nullable: false),
                        Inv_QtyIss = c.Double(),
                        Inv_QtyOnHand = c.Double(),
                        Inv_QtySent = c.Double(),
                        Inv_QtyRec = c.Double(),
                        Inv_Unit_ID = c.Int(),
                        Inv_Cost = c.Double(),
                    })
                .PrimaryKey(t => new { t.Tran_ID, t.FC_Item_ID, t.FC_Recipe_ID });
            
            CreateTable(
                "dbo.FC_Units",
                c => new
                    {
                        Unit_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 150),
                        Name2 = c.String(maxLength: 150),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Unit_ID);
            
            CreateTable(
                "dbo.FC_Vendor",
                c => new
                    {
                        Vend_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 150),
                        Name2 = c.String(maxLength: 150),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Vend_ID);
            
            CreateTable(
                "dbo.FC_Vou_Items",
                c => new
                    {
                        Vou_ID = c.Long(nullable: false),
                        FC_Item_ID = c.Int(nullable: false),
                        FC_Recipe_ID = c.Int(nullable: false),
                        Qty_OnHand = c.Double(),
                        Last_Cost = c.Double(),
                        Qty = c.Double(),
                        Unit_ID = c.Int(),
                        Cost = c.Double(),
                        Total_Cost = c.Double(),
                        Serial = c.Int(),
                        Inv_Qty_OnHand = c.Double(),
                        Inv_Last_Cost = c.Double(),
                        Inv_Qty = c.Double(),
                        Inv_Unit_ID = c.Int(),
                        Inv_Cost = c.Double(),
                    })
                .PrimaryKey(t => new { t.Vou_ID, t.FC_Item_ID, t.FC_Recipe_ID });
            
            CreateTable(
                "dbo.FC_Voucher",
                c => new
                    {
                        Vou_ID = c.Long(nullable: false),
                        Vou_No = c.Int(nullable: false),
                        Vou_Type = c.String(maxLength: 50),
                        Source_Type = c.String(maxLength: 50),
                        Status = c.String(maxLength: 50),
                        Reverse = c.Long(),
                        ArrivalDate = c.DateTime(),
                        Vend_ID = c.Int(),
                        Process_BI_ID = c.Long(),
                        Produce_Rcp_ID = c.Long(),
                        PO_ID = c.Long(),
                        Tran_ID = c.Long(),
                        Comment = c.String(maxLength: 500),
                        Post = c.Boolean(),
                        PostedDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Invn_ID = c.Int(),
                        Invn_Kit_ID = c.Int(),
                        WS = c.Int(),
                    })
                .PrimaryKey(t => t.Vou_ID);
            
            CreateTable(
                "dbo.HD_Company",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HD_Orders",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        Serial = c.Int(),
                        Check_ID = c.Long(),
                        Cust_ID = c.Long(),
                        Status = c.String(maxLength: 50),
                        Type_Order = c.String(maxLength: 50),
                        Pilot_ID = c.Int(),
                        Attach_Time = c.DateTime(),
                        Order_Pilot_ID = c.Long(),
                        Voided = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        OutLet_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        WS = c.Int(),
                        Order_Phone = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HD_Orders_Pilot",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        Serial = c.Int(),
                        Checks_Count = c.Int(),
                        Pilot_ID = c.Int(),
                        Pilot_Status = c.String(maxLength: 50),
                        Go_Time = c.DateTime(),
                        Back_Time = c.DateTime(),
                        Cash_In = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        OutLet_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        WS = c.Int(),
                        Pilot_Log_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.histAR_Table",
                c => new
                    {
                        Serial = c.Int(nullable: false, identity: true),
                        TypeAR = c.String(maxLength: 50),
                        Cheek = c.Int(),
                        GustCode = c.Int(),
                        GustName = c.String(maxLength: 500),
                        myDate = c.DateTime(),
                        TimeClose = c.String(maxLength: 50),
                        myValue = c.Single(),
                        Remain = c.Single(),
                        Paid = c.String(maxLength: 50),
                        Col1 = c.String(maxLength: 10),
                        Col2 = c.String(maxLength: 10),
                        Col3 = c.String(maxLength: 10),
                        Col4 = c.String(maxLength: 10),
                        Col5 = c.String(maxLength: 10),
                        Col6 = c.String(maxLength: 10),
                        Col7 = c.String(maxLength: 10),
                        Col8 = c.String(maxLength: 10),
                        Col9 = c.String(maxLength: 10),
                        Col10 = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Serial);
            
            CreateTable(
                "dbo.histChecks",
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
                "dbo.histChecksCompleted",
                c => new
                    {
                        Check_ID = c.Long(nullable: false),
                        Round_Check_Fired = c.Int(nullable: false),
                        Completed = c.Boolean(),
                        Completed_Time = c.DateTime(),
                        Voided = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.Check_ID, t.Round_Check_Fired });
            
            CreateTable(
                "dbo.histChecksItems",
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
                "dbo.histChecksItemsCompleted",
                c => new
                    {
                        Check_ID = c.Long(nullable: false),
                        Serial = c.Int(nullable: false),
                        Ref_Mod_Item = c.Int(),
                        Completed = c.Boolean(),
                        Completed_Time = c.DateTime(),
                        Voided = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.Check_ID, t.Serial });
            
            CreateTable(
                "dbo.histChecksItemsSerials",
                c => new
                    {
                        Check_ID = c.Long(nullable: false),
                        Serial = c.Int(nullable: false),
                        PrePaid_Serial = c.String(nullable: false, maxLength: 20),
                        Item_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.Check_ID, t.Serial, t.PrePaid_Serial });
            
            CreateTable(
                "dbo.histChecksItemsSettles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Check_ID = c.Long(nullable: false),
                        MOP_ID = c.Int(),
                        theValue = c.Double(),
                        Serials = c.String(maxLength: 50),
                        EpirDate = c.DateTime(),
                        Officer_ID = c.Int(),
                        Voided = c.Boolean(),
                        Voided_Reason = c.Int(),
                        Voided_By = c.Int(),
                        CL_ID = c.Int(),
                        Batch_No = c.Int(),
                        Void_Reason_Comment = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.histChecksItemsSettlesSummary",
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
                "dbo.histChecksTaxAdjTip",
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
            
            CreateTable(
                "dbo.histHD_Orders",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        Serial = c.Int(),
                        Check_ID = c.Long(),
                        Cust_ID = c.Long(),
                        Status = c.String(maxLength: 50),
                        Type_Order = c.String(maxLength: 50),
                        Pilot_ID = c.Int(),
                        Attach_Time = c.DateTime(),
                        Order_Pilot_ID = c.Long(),
                        Voided = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        OutLet_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        WS = c.Int(),
                        Order_Phone = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.histHD_Orders_Pilot",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        Serial = c.Int(),
                        Checks_Count = c.Int(),
                        Pilot_ID = c.Int(),
                        Pilot_Status = c.String(maxLength: 50),
                        Go_Time = c.DateTime(),
                        Back_Time = c.DateTime(),
                        Cash_In = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        OutLet_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        WS = c.Int(),
                        Pilot_Log_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Inv_Adjust_Items",
                c => new
                    {
                        Inv_Adj_ID = c.Long(nullable: false),
                        ItInv_ID = c.Int(nullable: false),
                        QtyOnHand = c.Double(),
                        Qty_Adj = c.Double(),
                        Comment = c.String(maxLength: 500),
                        Serial = c.Int(),
                    })
                .PrimaryKey(t => new { t.Inv_Adj_ID, t.ItInv_ID });
            
            CreateTable(
                "dbo.Inv_Adjust_Reason",
                c => new
                    {
                        Reason_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Inv_Item_Type = c.String(maxLength: 50),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Debit = c.Boolean(),
                        Credit = c.Boolean(),
                    })
                .PrimaryKey(t => t.Reason_ID);
            
            CreateTable(
                "dbo.Inv_Adjustment",
                c => new
                    {
                        Inv_Adj_ID = c.Long(nullable: false),
                        Inv_Adj_No = c.Int(),
                        Inv_Item_Type = c.String(maxLength: 50),
                        Reason_ID = c.Int(),
                        Status = c.String(maxLength: 50),
                        Notes = c.String(maxLength: 200),
                        Post = c.Boolean(),
                        PostedDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        OutLet_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        WS = c.Int(),
                    })
                .PrimaryKey(t => t.Inv_Adj_ID);
            
            CreateTable(
                "dbo.Inv_Categories",
                c => new
                    {
                        Inv_Cat_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Inv_Cat_ID);
            
            CreateTable(
                "dbo.Inventory_Items_Track",
                c => new
                    {
                        ItInv_ID = c.Int(nullable: false),
                        OutLet_ID = c.Int(nullable: false),
                        Rest_ID_Active = c.Int(nullable: false),
                        QTY = c.Double(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.ItInv_ID, t.OutLet_ID, t.Rest_ID_Active });
            
            CreateTable(
                "dbo.InventoryDefination",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        Name1 = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        IsMain = c.String(maxLength: 1),
                        IsOutlet = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.InventoryItems",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        Name1 = c.String(maxLength: 50),
                        Name2 = c.String(nullable: false, maxLength: 50),
                        Desc = c.String(nullable: false, maxLength: 50),
                        UsageUnit = c.Int(),
                        StockedUnit = c.Int(),
                        CategoryCode = c.Int(),
                        SubCategoryCode = c.Int(),
                        Yield = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Item_OutLets",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        OutLet_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Item_ID, t.OutLet_ID });
            
            CreateTable(
                "dbo.Items_Inventory",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 150),
                        Name2 = c.String(maxLength: 150),
                        BarCode = c.String(maxLength: 50),
                        Inv_Item_Type = c.String(maxLength: 50),
                        Cost = c.Double(),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Inv_Cat_ID = c.Int(),
                        Inv_Unit = c.String(maxLength: 50),
                        Min_Level = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ItemsAssimbly",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        Assimbly_ID = c.Int(nullable: false),
                        Active = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.Item_ID, t.Assimbly_ID });
            
            CreateTable(
                "dbo.ItemsChild",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        Child_Item_ID = c.Int(nullable: false),
                        Active = c.Boolean(),
                        Serial = c.Int(),
                    })
                .PrimaryKey(t => new { t.Item_ID, t.Child_Item_ID });
            
            CreateTable(
                "dbo.ItemsItInv",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        ItInv_ID = c.Int(nullable: false),
                        Qty = c.Double(),
                    })
                .PrimaryKey(t => new { t.Item_ID, t.ItInv_ID });
            
            CreateTable(
                "dbo.ItemsMonitors",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        Monitor_ID = c.Int(nullable: false),
                        Active = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.Item_ID, t.Monitor_ID });
            
            CreateTable(
                "dbo.ItemsPrices",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        PriceLVL_ID = c.Int(nullable: false),
                        Price_Value = c.Double(),
                    })
                .PrimaryKey(t => new { t.Item_ID, t.PriceLVL_ID });
            
            CreateTable(
                "dbo.ItemsPrinters",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        Printer_ID = c.Int(nullable: false),
                        Active = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.Item_ID, t.Printer_ID });
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        Name1 = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Note = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Log_Pilots",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Rest_ID_Active = c.Int(nullable: false),
                        Pilot_ID = c.Int(),
                        Status = c.String(maxLength: 50),
                        LogIn_Date = c.DateTime(),
                        LogOut_Date = c.DateTime(),
                        UserID = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.Rest_ID_Active });
            
            CreateTable(
                "dbo.LogInSys",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Rest_ID_Active = c.Int(nullable: false),
                        OutLet_ID = c.Int(nullable: false),
                        User_Code = c.Int(),
                        Status = c.String(maxLength: 50),
                        LogIn_Date = c.DateTime(),
                        LogOut_Date = c.DateTime(),
                        Start_CheckSerial = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.Rest_ID_Active, t.OutLet_ID });
            
            CreateTable(
                "dbo.Main_OutLet",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Main_Rest = c.String(maxLength: 200),
                        Main_OutLet = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MiniRecipe",
                c => new
                    {
                        Code = c.Int(nullable: false, identity: true),
                        RecipeCode = c.Int(),
                        MiniRecCode = c.Int(),
                        Qulity = c.Int(),
                        TotalMiniCost = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.ModifiesItems",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        ShowOnCheck = c.String(maxLength: 50),
                        ShowOnReport = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Monitors",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 100),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Move_Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item_ID = c.Int(nullable: false),
                        From_Check_ID = c.Long(nullable: false),
                        To_Check_ID = c.Long(),
                        Qty = c.Double(),
                        Move_Date = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Officers",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 100),
                        Dept_ID = c.Int(),
                        Notes = c.String(maxLength: 250),
                        Allow_Balance_Month = c.Double(),
                        begin_Month = c.Int(),
                        Block = c.Boolean(),
                        Reason_Block = c.String(maxLength: 250),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        Disc_Perc = c.Int(),
                        PriceLVL_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Out_Status_Reasons",
                c => new
                    {
                        Out_Reason_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.Out_Reason_ID);
            
            CreateTable(
                "dbo.OutLet_Adjustment",
                c => new
                    {
                        OutLet_ID = c.Int(nullable: false),
                        Adjustment_ID = c.Int(nullable: false),
                        FastFood = c.Boolean(),
                        HD = c.Boolean(),
                        DinIn = c.Boolean(),
                        DriveThru = c.Boolean(),
                        Cataring = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => new { t.OutLet_ID, t.Adjustment_ID });
            
            CreateTable(
                "dbo.OutLet_Discount",
                c => new
                    {
                        OutLet_ID = c.Int(nullable: false),
                        Disc_ID = c.Int(nullable: false),
                        FastFood = c.Boolean(),
                        HD = c.Boolean(),
                        DinIn = c.Boolean(),
                        DriveThru = c.Boolean(),
                        Cataring = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.OutLet_ID, t.Disc_ID });
            
            CreateTable(
                "dbo.OutLet_Officer",
                c => new
                    {
                        OutLet_ID = c.Int(nullable: false),
                        Officer_ID = c.Int(nullable: false),
                        FastFood = c.Boolean(),
                        HD = c.Boolean(),
                        DinIn = c.Boolean(),
                        DriveThru = c.Boolean(),
                        Cataring = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.OutLet_ID, t.Officer_ID });
            
            CreateTable(
                "dbo.OutLet_Pilot",
                c => new
                    {
                        OutLet_ID = c.Int(nullable: false),
                        Pilot_ID = c.Int(nullable: false),
                        HD = c.Boolean(),
                        Cataring = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.OutLet_ID, t.Pilot_ID });
            
            CreateTable(
                "dbo.OutLet_Promotion",
                c => new
                    {
                        OutLet_ID = c.Int(nullable: false),
                        Promo_ID = c.Int(nullable: false),
                        FastFood = c.Boolean(),
                        HD = c.Boolean(),
                        DinIn = c.Boolean(),
                        DriveThru = c.Boolean(),
                        Cataring = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.OutLet_ID, t.Promo_ID });
            
            CreateTable(
                "dbo.OutLet_Setup",
                c => new
                    {
                        OutLet_ID = c.Int(nullable: false),
                        OutLet_Name = c.String(maxLength: 250),
                        Province = c.String(maxLength: 50),
                        MinCharge = c.Double(),
                        InputMethod = c.String(maxLength: 50),
                        ServiceIDEntry = c.String(maxLength: 50),
                        ManagerIDEntry = c.String(maxLength: 50),
                        LogOnMoorButton = c.Int(),
                        MindigitesLogonNumber = c.Int(),
                        ServerscreenCheckSort = c.String(maxLength: 50),
                        Quicksaleloopback = c.Boolean(),
                        ShowDroponShiftreport = c.Boolean(),
                        Showoutofstockatlogon = c.Boolean(),
                        Delayfirecapability = c.Boolean(),
                        Allawserversopenallchecks = c.Boolean(),
                        CheckLocing = c.Boolean(),
                        Usemultimodesscreen = c.Boolean(),
                        UseDefinedTable = c.Boolean(),
                        AllawOpenMultiCheckInOneTable = c.Boolean(),
                        Usetablecontrolsystem = c.Boolean(),
                        Usealphanumarictable = c.Boolean(),
                        CheckPrinter = c.Int(),
                        PrintStatus = c.String(maxLength: 50),
                        ReciptDoNotPayWarning = c.Boolean(),
                        TipLineonCheckCCSlip = c.Boolean(),
                        PrintmaskedCC = c.Boolean(),
                        PrintCheckasBarCode = c.Boolean(),
                        TipCaptiononCheck = c.String(maxLength: 50),
                        Signatureinfoline = c.String(maxLength: 50),
                        ServerThankLine = c.String(maxLength: 50),
                        CheckPrinterType = c.String(maxLength: 50),
                        CheckType = c.String(maxLength: 50),
                        Header1 = c.String(maxLength: 150),
                        Header2 = c.String(maxLength: 150),
                        Header3 = c.String(maxLength: 150),
                        Header4 = c.String(maxLength: 150),
                        Header5 = c.String(maxLength: 150),
                        Footer1 = c.String(maxLength: 150),
                        Footer2 = c.String(maxLength: 150),
                        Footer3 = c.String(maxLength: 150),
                        Footer4 = c.String(maxLength: 150),
                        Footer5 = c.String(maxLength: 150),
                        AllawShiftReportwithopenchecks = c.Boolean(),
                        DoesthisoutletusehandhelsPC = c.Boolean(),
                        AllawZeroCovers = c.Boolean(),
                        AllServersaccesstoallchecks = c.Boolean(),
                        Printsummaryonworkorders = c.Boolean(),
                        Defultisthisclubmembertoyes = c.Boolean(),
                        Printsignonoff = c.Boolean(),
                        UseFullScreenSystem = c.Boolean(),
                        UseKitchenMonitors = c.Boolean(),
                        UseItemList = c.Boolean(),
                        RunKitchenPrinterOnHoldCase = c.Boolean(),
                        MainCourse = c.Int(),
                        DefaultLang = c.String(maxLength: 50),
                        Resolution = c.String(maxLength: 50),
                        MainPhoto = c.Binary(storeType: "image"),
                        LogoPhoto = c.Binary(storeType: "image"),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Assimbly_Kitchen = c.Boolean(),
                        Assimbly_Printer = c.Int(),
                        Generate_Order_No = c.Boolean(),
                        Min_Order_No = c.Int(),
                        Max_Order_No = c.Int(),
                        PrntEndShiftPilotDet = c.Boolean(),
                        PrntRcpOrderFromAssimbly = c.Boolean(),
                        CalcMinCharge = c.String(maxLength: 50),
                        ChkDinIn = c.String(maxLength: 50),
                        ChkHD = c.String(maxLength: 50),
                        ChkTakeAway = c.String(maxLength: 50),
                        ChkDriveThru = c.String(maxLength: 50),
                        tableblankColor = c.String(maxLength: 50),
                        tableuseColor = c.String(maxLength: 50),
                        checkprintColor = c.String(maxLength: 50),
                        checkcloseColor = c.String(maxLength: 50),
                        BlankAfterClose = c.Int(),
                        Preparation_Time = c.Int(),
                        Printer_Invoice_ID = c.Int(),
                        Print_Invoice_Count = c.Int(),
                        Allow_Reprint_Invoice = c.Boolean(),
                        Donot_Edit_Check_After_Print = c.Boolean(),
                        Used_Receipt_Pilot = c.Boolean(),
                        Can_Edit_Count_Close_Receipt_DinIn = c.Boolean(),
                        Print_Receipt_Order_No = c.Boolean(),
                        Count_Item_Serial = c.Boolean(),
                        Item_ID_Serial = c.Int(),
                        Start_Serial = c.Long(),
                        PriceLVL_ID = c.Int(),
                        Design_Receipt_Check = c.String(maxLength: 100),
                        Recpt_Count_TAway = c.Int(),
                        Cater_InFirstDay = c.Boolean(),
                        Cater_InTimeOrder = c.Boolean(),
                        MinutesCater = c.Int(),
                        PriceLVL_ID_DinIn = c.Int(),
                        PriceLVL_ID_HD = c.Int(),
                        PriceLVL_ID_TAwy = c.Int(),
                        PriceLVL_ID_DThru = c.Int(),
                        Auto_EndDay = c.Boolean(),
                        End_After_Hour = c.Int(),
                        ShowFireOnlyTAway = c.Boolean(),
                        Fire_NewTAway = c.Boolean(),
                        Quick_Pay_CashTAway = c.Boolean(),
                        UsedFirstKitchenPrinterOnly = c.Boolean(),
                        Required_Visa_Batch_No = c.Boolean(),
                        Required_Visa_Expiry_Date = c.Boolean(),
                        Required_VisaNo = c.Boolean(),
                        Show_Complementary_On_Check = c.Boolean(),
                        Different_Serial_For_Officer = c.Boolean(),
                        Show_Officer_ON_Fast_Rpt = c.Boolean(),
                        Assign_Waiter_In_Take_Away = c.Boolean(),
                        ShowFire_HoldTAway = c.Boolean(),
                        MinCharge_ByTime = c.Boolean(),
                        MinCharge_Start_Time = c.Int(),
                        MinCharge_End_Time = c.Int(),
                        Form_Lock = c.Int(),
                        Recpt_Count_Dinin = c.Int(),
                        Manager_End_Day_Machine_Date = c.Boolean(),
                        Manager_PW_End_Day = c.String(maxLength: 150),
                        Print_Direct_Check = c.Boolean(),
                        Print_Direct_Kitchen = c.Boolean(),
                        Print_Mod_Last_Item_on_Check = c.Boolean(),
                        Show_Price_On_Direct_Kit_Open_Price = c.Boolean(),
                        Show_Price_On_Direct_Kit_Open_Food = c.Boolean(),
                        Menu_Items_Count = c.Int(),
                        MinCharge_Tax_ID = c.Int(),
                        Min_Order_Level = c.Double(),
                        Target_Daily = c.Double(),
                        Target_Week = c.Double(),
                        Target_Month = c.Double(),
                        Security_Customer = c.Boolean(),
                        Security_Pilot = c.Boolean(),
                        Allow_No_Reason_Comp = c.Boolean(),
                        Allow_No_Reason_Void = c.Boolean(),
                        Allow_No_Reason_Discount = c.Boolean(),
                        Allow_Open_Check_WithoutItems_WithBalance = c.Boolean(),
                    })
                .PrimaryKey(t => t.OutLet_ID);
            
            CreateTable(
                "dbo.OutLet_Tax",
                c => new
                    {
                        OutLet_ID = c.Int(nullable: false),
                        Tax_ID = c.Int(nullable: false),
                        FastFood = c.Boolean(),
                        HD = c.Boolean(),
                        DinIn = c.Boolean(),
                        DriveThru = c.Boolean(),
                        Cataring = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => new { t.OutLet_ID, t.Tax_ID });
            
            CreateTable(
                "dbo.OutletSetupMeals",
                c => new
                    {
                        Serial = c.Int(nullable: false),
                        OutletCode = c.Int(),
                        Name = c.String(maxLength: 50),
                        Start = c.String(maxLength: 50),
                        End = c.String(maxLength: 50),
                        BuffetItem = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Serial);
            
            CreateTable(
                "dbo.OutletSetup",
                c => new
                    {
                        OutLetCode = c.Int(nullable: false),
                        OutletName = c.String(maxLength: 1000),
                        Address = c.String(maxLength: 1000),
                        City = c.String(maxLength: 50),
                        Merchant = c.String(maxLength: 50),
                        Status = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        OutletType = c.String(maxLength: 50),
                        InputMethode = c.String(maxLength: 50),
                        MaxdigitesLoonNumber = c.String(maxLength: 50),
                        ServerscreenCheckSort = c.String(maxLength: 50),
                        ServiceIDEntry = c.String(maxLength: 50),
                        ManagerIDEntry = c.String(maxLength: 50),
                        LogOnMoorButton = c.String(maxLength: 50),
                        MusterCurrancy = c.String(maxLength: 50),
                        Usetablecontrolsystem = c.String(maxLength: 50),
                        Usealphanumarictable = c.String(maxLength: 50),
                        ShowDroponShiftreport = c.String(maxLength: 50),
                        Showoutofstockatlogon = c.String(maxLength: 50),
                        Delayfirecapability = c.String(maxLength: 50),
                        Allawserversopenallchecs = c.String(maxLength: 50),
                        CheckLocing = c.String(maxLength: 50),
                        AskbargustIDCovers = c.String(maxLength: 50),
                        Usemultimodesscreen = c.String(maxLength: 50),
                        Quicksaleloopback = c.String(maxLength: 50),
                        fireOption = c.String(maxLength: 50),
                        clcTaxes = c.String(maxLength: 50),
                        InclusiveVatTax = c.String(maxLength: 50),
                        AllawMultiCurrencySettlements = c.String(maxLength: 50),
                        AllawTipEntryInSettlementScreen = c.String(maxLength: 50),
                        AllawPartialPaymentOfChecks = c.String(maxLength: 50),
                        CheckType = c.String(maxLength: 50),
                        ItemsOrder = c.String(maxLength: 50),
                        CheckPrinterType = c.String(maxLength: 50),
                        ReciptDoNotPayWarning = c.String(maxLength: 50),
                        TipLineonCheckCCSlip = c.String(maxLength: 50),
                        PintmskedCCandexpirationdateongeneralrespit = c.String(maxLength: 50),
                        PrintVatTaxrecaponroomsettlementrecpicts = c.String(maxLength: 50),
                        AtomaticReceipt = c.String(maxLength: 50),
                        PrintCheckasBarCode = c.String(maxLength: 50),
                        TipCaptiononCheck = c.String(maxLength: 50),
                        Signatureinfoline = c.String(maxLength: 50),
                        ServerThankLine = c.String(maxLength: 50),
                        LocalCurrancyRate = c.String(maxLength: 50),
                        Hader1 = c.String(maxLength: 50),
                        Hader2 = c.String(maxLength: 50),
                        Hader3 = c.String(maxLength: 50),
                        Hader4 = c.String(maxLength: 50),
                        Hader5 = c.String(maxLength: 50),
                        Footer1 = c.String(maxLength: 50),
                        Footer2 = c.String(maxLength: 50),
                        Footer3 = c.String(maxLength: 50),
                        Footer4 = c.String(maxLength: 50),
                        Footer5 = c.String(maxLength: 50),
                        AllawShiftReportwithopenchecks = c.String(maxLength: 50),
                        DoesthisoutletusehandhelsPC = c.String(maxLength: 50),
                        AllawZeroCovers = c.String(maxLength: 50),
                        AllServersaccesstoallchecks = c.String(maxLength: 50),
                        Printsummaryonworkorders = c.String(maxLength: 50),
                        Defultisthisclubmembertoyes = c.String(maxLength: 50),
                        Printsignonoff = c.String(maxLength: 50),
                        Usecustomkeyconfiguration = c.String(maxLength: 50),
                        AutoadvancedSeatnumbers = c.String(maxLength: 50),
                        TrackMaleFemale = c.String(maxLength: 50),
                        SortbygustonOrderScreen = c.String(maxLength: 50),
                        AskseatonQTYOrder = c.String(maxLength: 50),
                        AskChecktipatlogoff = c.String(maxLength: 50),
                        MainPreseteCode = c.Int(),
                        MainPhoto = c.String(maxLength: 500),
                        Logo = c.String(maxLength: 522),
                        LogoVlue = c.Binary(storeType: "image"),
                        ChickPrinter = c.Int(),
                        Option1 = c.String(maxLength: 50),
                        Option2 = c.String(maxLength: 50),
                        Option3 = c.String(maxLength: 50),
                        Option4 = c.String(maxLength: 50),
                        Option5 = c.String(maxLength: 50),
                        Option6 = c.String(maxLength: 50),
                        Option7 = c.String(maxLength: 50),
                        Option8 = c.String(maxLength: 50),
                        Option9 = c.String(maxLength: 50),
                        Option10 = c.String(maxLength: 50),
                        Option11 = c.String(maxLength: 50),
                        Option12 = c.String(maxLength: 50),
                        Option13 = c.String(maxLength: 50),
                        Option14 = c.String(maxLength: 50),
                        Option15 = c.String(maxLength: 50),
                        Option16 = c.String(maxLength: 50),
                        Option17 = c.String(maxLength: 50),
                        Option18 = c.String(maxLength: 50),
                        Option19 = c.String(maxLength: 50),
                        Option20 = c.String(maxLength: 50),
                        SetPrinterLangugeAccordingTo = c.String(maxLength: 50),
                        AssemblerPath = c.String(maxLength: 1000),
                        Option21 = c.String(maxLength: 50),
                        Option22 = c.String(maxLength: 50),
                        Option23 = c.String(maxLength: 50),
                        Option24 = c.String(maxLength: 50),
                        Option25 = c.String(maxLength: 50),
                        Option26 = c.String(maxLength: 50),
                        Option27 = c.String(maxLength: 50),
                        Option28 = c.String(maxLength: 50),
                        Option29 = c.String(maxLength: 50),
                        Option30 = c.String(maxLength: 50),
                        Option31 = c.String(maxLength: 50),
                        Option32 = c.String(maxLength: 50),
                        Option33 = c.String(maxLength: 50),
                        Option34 = c.String(maxLength: 50),
                        Option35 = c.String(maxLength: 50),
                        Option36 = c.String(maxLength: 50),
                        Option37 = c.String(maxLength: 50),
                        Option38 = c.String(maxLength: 50),
                        Option39 = c.String(maxLength: 50),
                        Option40 = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.OutLetCode);
            
            CreateTable(
                "dbo.PaidOut_Tranactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Paid_ID = c.Int(nullable: false),
                        Paid_Date = c.DateTime(),
                        RefNumber = c.String(maxLength: 50),
                        Paid_Amount = c.Double(),
                        Paid_Desc = c.String(maxLength: 500),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        OutLet_ID_Active = c.Int(),
                        Rest_ID_Active = c.Int(),
                        WS = c.Int(),
                        Voided = c.Boolean(),
                        Voided_Time = c.DateTime(),
                        Voided_Reason = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PaidOut_Void_Reasons",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PaidOutReasons",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Payment_Void_Reasons",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PaymentMethodes",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        MOP_Type = c.Int(),
                        OredrBy = c.Int(),
                        Photo = c.Binary(storeType: "image"),
                        OpenDrwer = c.Boolean(),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Manager = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Phone_Keys",
                c => new
                    {
                        Rest_ID_Active = c.Int(nullable: false),
                        Serial = c.Int(nullable: false),
                        Phone_Key = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.Rest_ID_Active, t.Serial });
            
            CreateTable(
                "dbo.Pilots",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Phone = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Address = c.String(maxLength: 150),
                        Active = c.Boolean(),
                        Exist = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        PassCode = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Point_Items",
                c => new
                    {
                        Point_ID = c.Int(nullable: false),
                        Serial = c.Int(nullable: false),
                        Point_Type = c.String(maxLength: 50),
                        ICS_ID = c.Int(),
                        Point_For_One = c.Int(),
                    })
                .PrimaryKey(t => new { t.Point_ID, t.Serial });
            
            CreateTable(
                "dbo.Points",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Remove_When_Disc = c.Boolean(),
                        Start_Point = c.Int(),
                        Max_Point = c.Int(),
                        Valid_Days = c.Int(),
                        Notes = c.String(maxLength: 250),
                        Cancel = c.Boolean(),
                        CancelledDate = c.DateTime(),
                        Cancelled_By = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        OutLet_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pre_Paid_Adjust",
                c => new
                    {
                        PrePaid_Adj_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Description = c.String(maxLength: 250),
                        Item_ID = c.Int(),
                        Post = c.Boolean(),
                        PostedDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.PrePaid_Adj_ID);
            
            CreateTable(
                "dbo.Pre_Paid_Card",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        Set_Expiry_Period = c.Boolean(),
                        Expiry_Period_By_Days = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.Item_ID);
            
            CreateTable(
                "dbo.Pre_Paid_Card_Group",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        PrePaid_Group_ID = c.Int(nullable: false),
                        Serial = c.Int(),
                        Qty = c.Double(),
                    })
                .PrimaryKey(t => new { t.Item_ID, t.PrePaid_Group_ID });
            
            CreateTable(
                "dbo.Pre_Paid_Groups",
                c => new
                    {
                        PrePaid_Group_ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.PrePaid_Group_ID);
            
            CreateTable(
                "dbo.PrePaid_Adjust_Serial",
                c => new
                    {
                        PrePaid_Serial = c.String(nullable: false, maxLength: 20),
                        Rest_ID_Active = c.Int(nullable: false),
                        PrePaid_Adj_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PrePaid_Serial, t.Rest_ID_Active });
            
            CreateTable(
                "dbo.PrePaid_Group_Items",
                c => new
                    {
                        PrePaid_Group_ID = c.Int(nullable: false),
                        Index_Item = c.Int(nullable: false),
                        Item_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PrePaid_Group_ID, t.Index_Item });
            
            CreateTable(
                "dbo.Presets",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Image_Preset = c.Binary(storeType: "image"),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        OutLet_ID_Active = c.Int(),
                        ByTime = c.Boolean(),
                        Start_Time = c.Int(),
                        End_Time = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Price_Levels",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Print_Fast_Rpt",
                c => new
                    {
                        SysDate = c.DateTime(nullable: false),
                        Rpt_Code = c.Int(nullable: false),
                        OutLet_ID = c.Int(nullable: false),
                        Rest_ID_Active = c.Int(nullable: false),
                        Rpt_Name = c.String(maxLength: 100),
                        Num_Print = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        WS = c.Int(),
                    })
                .PrimaryKey(t => new { t.SysDate, t.Rpt_Code, t.OutLet_ID, t.Rest_ID_Active });
            
            CreateTable(
                "dbo.Print_Invoice",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        OutLet_ID = c.Int(nullable: false),
                        Check_ID = c.Long(),
                        CreateDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.OutLet_ID });
            
            CreateTable(
                "dbo.Printers",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        PrinterLanguage = c.String(maxLength: 50),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Promotion_Gift_Items",
                c => new
                    {
                        Promo_ID = c.Int(nullable: false),
                        Serial = c.Int(nullable: false),
                        ICS_Type = c.String(maxLength: 50),
                        ICS_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.Promo_ID, t.Serial });
            
            CreateTable(
                "dbo.Promotion_Items",
                c => new
                    {
                        Promo_ID = c.Int(nullable: false),
                        Serial = c.Int(nullable: false),
                        ICS_Type = c.String(maxLength: 50),
                        ICS_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.Promo_ID, t.Serial });
            
            CreateTable(
                "dbo.Promotion",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Status = c.String(maxLength: 50),
                        Promo_Type = c.String(maxLength: 50),
                        Discount_ID = c.Int(),
                        Check_No = c.String(maxLength: 50),
                        Start_Date = c.DateTime(),
                        End_Date = c.DateTime(),
                        Notes = c.String(maxLength: 250),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        QtyBO = c.Int(),
                        GiftQty = c.Int(),
                        ByTime = c.Boolean(),
                        Start_Time = c.Int(),
                        End_Time = c.Int(),
                        Satur_day = c.Boolean(),
                        Sun_day = c.Boolean(),
                        Mon_day = c.Boolean(),
                        Tues_day = c.Boolean(),
                        Wednes_day = c.Boolean(),
                        Thurs_day = c.Boolean(),
                        Fri_day = c.Boolean(),
                        DinIn = c.Boolean(),
                        HD = c.Boolean(),
                        FastFood = c.Boolean(),
                        DriveThru = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RecipeItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RecCode = c.Int(nullable: false),
                        ItemCode = c.Int(),
                        CatCode = c.Int(),
                        SubCode = c.Int(),
                        UnitCode = c.Int(),
                        Qty = c.Int(),
                        Cost = c.Decimal(storeType: "money"),
                        CostPer = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Recipe",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        CrossCode = c.Int(),
                        Qty = c.Int(),
                        UnitCode = c.Int(),
                        Comment = c.String(maxLength: 50),
                        TotalCost = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Restaurant_Setup",
                c => new
                    {
                        Rest_ID = c.Int(nullable: false),
                        Address = c.String(maxLength: 250),
                        City = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 100),
                        CataringPrintCase = c.String(maxLength: 50),
                        CalcAdjBeforeDisc = c.Boolean(),
                        CalcTaxBeforeDisc = c.Boolean(),
                        CalcDiscOnNetTotal = c.Boolean(),
                        InclusiveVatTax = c.Boolean(),
                        AllawMultiCurrencySettlement = c.Boolean(),
                        AllawTipEntryInSettlementScreen = c.Boolean(),
                        AllawPartialPaymentOfCheck = c.Boolean(),
                        RemoveMultiPayment = c.Boolean(),
                        PrinterLang = c.String(maxLength: 50),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Rest_ID);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        IP_Address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Setup_Call_Center",
                c => new
                    {
                        Rest_ID_Active = c.Int(nullable: false),
                        Port = c.Int(),
                        IP_Address = c.String(maxLength: 50),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Rest_ID_Active);
            
            CreateTable(
                "dbo.Setup_EndDay",
                c => new
                    {
                        OutLet_ID = c.Int(nullable: false),
                        Log_Out_All_Users = c.Boolean(),
                        Prnt_Z_Out = c.Boolean(),
                        Prnt_Pilots = c.Boolean(),
                        Prnt_Pilots_Balance = c.Boolean(),
                        Prnt_Items_Sales = c.Boolean(),
                        Prnt_Qty_Sold = c.Boolean(),
                        Prnt_Daily_MOP = c.Boolean(),
                        Prnt_Inventory_Items = c.Boolean(),
                        Prnt_Cashier_Daily = c.Boolean(),
                        Prnt_All_Users_Shift = c.Boolean(),
                    })
                .PrimaryKey(t => t.OutLet_ID);
            
            CreateTable(
                "dbo.Setup_Meals",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        Start_Time = c.Int(),
                        End_Time = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        OutLet_ID_Active = c.Int(),
                        PriceLVL_ID = c.Int(),
                        Satur_day = c.Boolean(),
                        Sun_day = c.Boolean(),
                        Mon_day = c.Boolean(),
                        Tues_day = c.Boolean(),
                        Wednes_day = c.Boolean(),
                        Thurs_day = c.Boolean(),
                        Fri_day = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Setup_Outlet_Mail_Rpt",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        OutLet_ID_Active = c.Int(),
                        Last_Sent = c.DateTime(),
                        File_Type = c.Int(),
                        From_Mail = c.String(maxLength: 150),
                        Smtp_Host = c.String(maxLength: 150),
                        Smtp_Port = c.Int(),
                        EnableSsl = c.Boolean(),
                        User_Name = c.String(maxLength: 150),
                        PassWord = c.String(maxLength: 150),
                        To_Mail = c.String(maxLength: 150),
                        Prnt_Z_Out = c.Boolean(),
                        Prnt_Pilots = c.Boolean(),
                        Prnt_Pilots_Balance = c.Boolean(),
                        Prnt_Qty_Sold = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Setup_Periods",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        From_Day = c.Int(),
                        From_Month = c.Int(),
                        To_Day = c.Int(),
                        To_Month = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Setup_Quick_Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name_Item = c.String(maxLength: 50),
                        Desc_Item = c.String(maxLength: 50),
                        Rest_ID_Active = c.Int(),
                        OutLet_ID_Active = c.Int(),
                        CreateDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Shelfs",
                c => new
                    {
                        ShelfCode = c.Int(nullable: false),
                        LocCode = c.Int(nullable: false),
                        ShelfName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ShelfCode);
            
            CreateTable(
                "dbo.StockedItemCategory",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.StockedItemsSubCategory",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        CategoryCode = c.Int(),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.SystemDate",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SysDate = c.DateTime(),
                        Start_Time = c.DateTime(),
                        End_Time = c.DateTime(),
                        Status = c.String(maxLength: 50),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        OutLet_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TablesGuest",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        tblBulk = c.String(maxLength: 50),
                        CoversCapacity = c.Int(),
                        DinRoom_ID = c.Int(),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        OutLet_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Taxes",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        taxType = c.String(maxLength: 50),
                        taxValue = c.Double(),
                        MinimumPersonToClc = c.Int(),
                        Timed = c.Boolean(),
                        tFrom = c.String(maxLength: 50),
                        tTo = c.String(maxLength: 50),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        SetDefault = c.Boolean(),
                        For_Each_Cover = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Temp_Button",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        txtFont = c.String(maxLength: 50),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tmp_Checks",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        CheckSerail = c.Int(nullable: false),
                        CheckTitel = c.String(maxLength: 50),
                        CheckType = c.String(maxLength: 50),
                        Covers = c.Int(),
                        MyTable = c.String(maxLength: 50),
                        MyCase = c.String(maxLength: 50),
                        MyStatus = c.String(maxLength: 50),
                        RefranceTo = c.Int(),
                        myDateTime = c.DateTime(),
                        OpenIn = c.DateTime(),
                        ClosedIn = c.DateTime(),
                        Cust_ID = c.Int(),
                        Server_ID = c.Int(),
                        Casher_ID = c.Int(),
                        Admin_ID = c.Int(),
                        OutLet_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.ID, t.CheckSerail });
            
            CreateTable(
                "dbo.Tmp_ChecksItems",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Serial = c.Int(nullable: false),
                        myCase = c.String(nullable: false, maxLength: 50),
                        CheckSerail = c.Int(),
                        Item_ID = c.Int(),
                        QTY = c.Single(),
                        UnitPrice = c.Double(),
                        TotalPrice = c.Double(),
                        DicountValue = c.Double(),
                        NetPrice = c.Double(),
                        Refrance_ID = c.Int(),
                        Fired = c.Boolean(),
                        Fired_Time = c.DateTime(),
                        Voided = c.Boolean(),
                        Voided_Time = c.DateTime(),
                        Voided_Reason = c.String(maxLength: 250),
                        Completed_Time = c.DateTime(),
                        Printer_ID = c.Int(),
                        Complement = c.String(maxLength: 50),
                        Status = c.String(maxLength: 50),
                        IsModifier = c.Boolean(),
                        Ref_Mod_Item = c.Int(),
                        IsAssimply = c.Boolean(),
                        Ref_Ass_Item = c.Int(),
                        Taxable = c.Boolean(),
                        NoServiceCharge = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.ID, t.Serial, t.myCase });
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        Name1 = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Update_Item_Price",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item_ID = c.Int(nullable: false),
                        PriceLVL_ID = c.Int(nullable: false),
                        Price_Value = c.Double(),
                        Price_Date = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.User_OutLets",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        OutLet_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.OutLet_ID });
            
            CreateTable(
                "dbo.UserClasses",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserDefnation",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Password = c.String(maxLength: 200),
                        UserName = c.String(maxLength: 50),
                        UserClass_ID = c.Int(),
                        MyLanguage = c.String(maxLength: 50),
                        tital = c.String(maxLength: 50),
                        FullName = c.String(maxLength: 200),
                        Adress = c.String(maxLength: 250),
                        jop = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 150),
                        Mobile = c.String(maxLength: 150),
                        Email = c.String(maxLength: 150),
                        PassCode = c.String(maxLength: 200),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        IsWaiter = c.Boolean(),
                        Ref_Code = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.UsersPrivileges",
                c => new
                    {
                        UserClass_ID = c.Int(nullable: false),
                        Rest_ID_Active = c.Int(nullable: false),
                        ClassPrv = c.String(maxLength: 2000),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => new { t.UserClass_ID, t.Rest_ID_Active });
            
            CreateTable(
                "dbo.VendorItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Items_Id = c.Int(),
                        Vend_Id = c.Int(),
                        Cost = c.Double(),
                        Comment = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Contacts = c.String(maxLength: 150),
                        Description = c.String(maxLength: 150),
                        Address = c.String(maxLength: 250),
                        Country = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        Telephone = c.String(maxLength: 50),
                        Fax = c.String(maxLength: 50),
                        Mail = c.String(maxLength: 50),
                        Active = c.String(maxLength: 1),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VersionDB",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ver_DB = c.Double(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VoidReasons",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        Name = c.String(maxLength: 50),
                        Name2 = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Active = c.Boolean(),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                        Rest_ID_Active = c.Int(),
                        Effect_Invn = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VoucherItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Items_Id = c.Int(),
                        Vou_Id = c.Int(),
                        Qty = c.Int(),
                        Cost = c.Double(),
                        TotalCost = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Voucher",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Code = c.Int(),
                        Vou_Type = c.Int(),
                        Vend_Id = c.Int(),
                        Vou_Date = c.DateTime(),
                        Description = c.String(maxLength: 250),
                        Active = c.String(maxLength: 1),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        User_Id = c.Int(),
                        Invc_No = c.String(maxLength: 50),
                        MOP = c.String(maxLength: 10),
                        Due_Date = c.DateTime(),
                        Paid = c.String(maxLength: 2),
                        Reff_No = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Voucher");
            DropTable("dbo.VoucherItems");
            DropTable("dbo.VoidReasons");
            DropTable("dbo.VersionDB");
            DropTable("dbo.Vendors");
            DropTable("dbo.VendorItems");
            DropTable("dbo.UsersPrivileges");
            DropTable("dbo.UserDefnation");
            DropTable("dbo.UserClasses");
            DropTable("dbo.User_OutLets");
            DropTable("dbo.Update_Item_Price");
            DropTable("dbo.Units");
            DropTable("dbo.Tmp_ChecksItems");
            DropTable("dbo.Tmp_Checks");
            DropTable("dbo.Temp_Button");
            DropTable("dbo.Taxes");
            DropTable("dbo.TablesGuest");
            DropTable("dbo.SystemDate");
            DropTable("dbo.StockedItemsSubCategory");
            DropTable("dbo.StockedItemCategory");
            DropTable("dbo.Shelfs");
            DropTable("dbo.Setup_Quick_Customer");
            DropTable("dbo.Setup_Periods");
            DropTable("dbo.Setup_Outlet_Mail_Rpt");
            DropTable("dbo.Setup_Meals");
            DropTable("dbo.Setup_EndDay");
            DropTable("dbo.Setup_Call_Center");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Restaurant_Setup");
            DropTable("dbo.Recipe");
            DropTable("dbo.RecipeItems");
            DropTable("dbo.Promotion");
            DropTable("dbo.Promotion_Items");
            DropTable("dbo.Promotion_Gift_Items");
            DropTable("dbo.Printers");
            DropTable("dbo.Print_Invoice");
            DropTable("dbo.Print_Fast_Rpt");
            DropTable("dbo.Price_Levels");
            DropTable("dbo.Presets");
            DropTable("dbo.PrePaid_Group_Items");
            DropTable("dbo.PrePaid_Adjust_Serial");
            DropTable("dbo.Pre_Paid_Groups");
            DropTable("dbo.Pre_Paid_Card_Group");
            DropTable("dbo.Pre_Paid_Card");
            DropTable("dbo.Pre_Paid_Adjust");
            DropTable("dbo.Points");
            DropTable("dbo.Point_Items");
            DropTable("dbo.Pilots");
            DropTable("dbo.Phone_Keys");
            DropTable("dbo.PaymentMethodes");
            DropTable("dbo.Payment_Void_Reasons");
            DropTable("dbo.PaidOutReasons");
            DropTable("dbo.PaidOut_Void_Reasons");
            DropTable("dbo.PaidOut_Tranactions");
            DropTable("dbo.OutletSetup");
            DropTable("dbo.OutletSetupMeals");
            DropTable("dbo.OutLet_Tax");
            DropTable("dbo.OutLet_Setup");
            DropTable("dbo.OutLet_Promotion");
            DropTable("dbo.OutLet_Pilot");
            DropTable("dbo.OutLet_Officer");
            DropTable("dbo.OutLet_Discount");
            DropTable("dbo.OutLet_Adjustment");
            DropTable("dbo.Out_Status_Reasons");
            DropTable("dbo.Officers");
            DropTable("dbo.Move_Items");
            DropTable("dbo.Monitors");
            DropTable("dbo.ModifiesItems");
            DropTable("dbo.MiniRecipe");
            DropTable("dbo.Main_OutLet");
            DropTable("dbo.LogInSys");
            DropTable("dbo.Log_Pilots");
            DropTable("dbo.Locations");
            DropTable("dbo.ItemsPrinters");
            DropTable("dbo.ItemsPrices");
            DropTable("dbo.ItemsMonitors");
            DropTable("dbo.ItemsItInv");
            DropTable("dbo.ItemsChild");
            DropTable("dbo.ItemsAssimbly");
            DropTable("dbo.Items_Inventory");
            DropTable("dbo.Item_OutLets");
            DropTable("dbo.InventoryItems");
            DropTable("dbo.InventoryDefination");
            DropTable("dbo.Inventory_Items_Track");
            DropTable("dbo.Inv_Categories");
            DropTable("dbo.Inv_Adjustment");
            DropTable("dbo.Inv_Adjust_Reason");
            DropTable("dbo.Inv_Adjust_Items");
            DropTable("dbo.histHD_Orders_Pilot");
            DropTable("dbo.histHD_Orders");
            DropTable("dbo.histChecksTaxAdjTip");
            DropTable("dbo.histChecksItemsSettlesSummary");
            DropTable("dbo.histChecksItemsSettles");
            DropTable("dbo.histChecksItemsSerials");
            DropTable("dbo.histChecksItemsCompleted");
            DropTable("dbo.histChecksItems");
            DropTable("dbo.histChecksCompleted");
            DropTable("dbo.histChecks");
            DropTable("dbo.histAR_Table");
            DropTable("dbo.HD_Orders_Pilot");
            DropTable("dbo.HD_Orders");
            DropTable("dbo.HD_Company");
            DropTable("dbo.FC_Voucher");
            DropTable("dbo.FC_Vou_Items");
            DropTable("dbo.FC_Vendor");
            DropTable("dbo.FC_Units");
            DropTable("dbo.FC_Transfer_Items");
            DropTable("dbo.FC_Transfer");
            DropTable("dbo.FC_SubCategories");
            DropTable("dbo.FC_Setup");
            DropTable("dbo.FC_Recipes");
            DropTable("dbo.FC_Recipe_Items");
            DropTable("dbo.FC_ReceivdData");
            DropTable("dbo.FC_Produce_Recipe");
            DropTable("dbo.FC_Produce_Rcp_Child");
            DropTable("dbo.FC_Process_BI_Child");
            DropTable("dbo.FC_Process_BI");
            DropTable("dbo.FC_Kitchen_Outlets");
            DropTable("dbo.FC_ItemsChild");
            DropTable("dbo.FC_Items_For_Invn_Kit");
            DropTable("dbo.FC_Items");
            DropTable("dbo.FC_Item_Invn_Qty");
            DropTable("dbo.FC_Item_Cost");
            DropTable("dbo.FC_Invn_Kitchen");
            DropTable("dbo.FC_Invn_kit_Variance_Items");
            DropTable("dbo.FC_Invn_kit_Variance");
            DropTable("dbo.FC_Invn_kit_Sheet_Items");
            DropTable("dbo.FC_Invn_kit_Sheet");
            DropTable("dbo.FC_Inventory");
            DropTable("dbo.FC_Convert_Units");
            DropTable("dbo.FC_Categories");
            DropTable("dbo.FC_Bulk_Items_Child");
            DropTable("dbo.FC_Bulk_Items");
            DropTable("dbo.FC_Adjustment");
            DropTable("dbo.FC_Adjust_Reason");
            DropTable("dbo.FC_Adjust_Items");
            DropTable("dbo.End_Shift_User");
            DropTable("dbo.dtproperties");
            DropTable("dbo.DiscountsCatrgories");
            DropTable("dbo.Discounts");
            DropTable("dbo.Discount_Reasons");
            DropTable("dbo.Disable_Table");
            DropTable("dbo.DiningRooms");
            DropTable("dbo.Design_DiningRooms_Tables");
            DropTable("dbo.Design_DiningRooms");
            DropTable("dbo.Departments");
            DropTable("dbo.Customers_Telephone");
            DropTable("dbo.Customers");
            DropTable("dbo.Customer_Points");
            DropTable("dbo.Currency_Rate");
            DropTable("dbo.Convert_Points");
            DropTable("dbo.Complementary_Reasons");
            DropTable("dbo.CL");
            DropTable("dbo.ChecksItemsSettles");
            DropTable("dbo.ChecksItemsSerials");
            DropTable("dbo.ChecksItemsCompleted");
            DropTable("dbo.ChecksCompleted");
            DropTable("dbo.Change_Server");
            DropTable("dbo.Catering");
            DropTable("dbo.Categories");
            DropTable("dbo.Cat_histChecksItems");
            DropTable("dbo.Cat_histChecks");
            DropTable("dbo.Cat_ChecksItems");
            DropTable("dbo.Cat_Checks");
            DropTable("dbo.Cash_Drawer");
            DropTable("dbo.AvailableTable");
            DropTable("dbo.Assign_Drawer");
            DropTable("dbo.AR_Customers");
            DropTable("dbo.AR_Checks_Pay");
            DropTable("dbo.AR_Checks");
            DropTable("dbo.Aging");
            DropTable("dbo.Adjustments");
        }
    }
}
