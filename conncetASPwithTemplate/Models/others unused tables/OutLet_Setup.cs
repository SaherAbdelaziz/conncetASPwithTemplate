namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OutLet_Setup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutLet_ID { get; set; }

        [StringLength(250)]
        public string OutLet_Name { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        public double? MinCharge { get; set; }

        [StringLength(50)]
        public string InputMethod { get; set; }

        [StringLength(50)]
        public string ServiceIDEntry { get; set; }

        [StringLength(50)]
        public string ManagerIDEntry { get; set; }

        public int? LogOnMoorButton { get; set; }

        public int? MindigitesLogonNumber { get; set; }

        [StringLength(50)]
        public string ServerscreenCheckSort { get; set; }

        public bool? Quicksaleloopback { get; set; }

        public bool? ShowDroponShiftreport { get; set; }

        public bool? Showoutofstockatlogon { get; set; }

        public bool? Delayfirecapability { get; set; }

        public bool? Allawserversopenallchecks { get; set; }

        public bool? CheckLocing { get; set; }

        public bool? Usemultimodesscreen { get; set; }

        public bool? UseDefinedTable { get; set; }

        public bool? AllawOpenMultiCheckInOneTable { get; set; }

        public bool? Usetablecontrolsystem { get; set; }

        public bool? Usealphanumarictable { get; set; }

        public int? CheckPrinter { get; set; }

        [StringLength(50)]
        public string PrintStatus { get; set; }

        public bool? ReciptDoNotPayWarning { get; set; }

        public bool? TipLineonCheckCCSlip { get; set; }

        public bool? PrintmaskedCC { get; set; }

        public bool? PrintCheckasBarCode { get; set; }

        [StringLength(50)]
        public string TipCaptiononCheck { get; set; }

        [StringLength(50)]
        public string Signatureinfoline { get; set; }

        [StringLength(50)]
        public string ServerThankLine { get; set; }

        [StringLength(50)]
        public string CheckPrinterType { get; set; }

        [StringLength(50)]
        public string CheckType { get; set; }

        [StringLength(150)]
        public string Header1 { get; set; }

        [StringLength(150)]
        public string Header2 { get; set; }

        [StringLength(150)]
        public string Header3 { get; set; }

        [StringLength(150)]
        public string Header4 { get; set; }

        [StringLength(150)]
        public string Header5 { get; set; }

        [StringLength(150)]
        public string Footer1 { get; set; }

        [StringLength(150)]
        public string Footer2 { get; set; }

        [StringLength(150)]
        public string Footer3 { get; set; }

        [StringLength(150)]
        public string Footer4 { get; set; }

        [StringLength(150)]
        public string Footer5 { get; set; }

        public bool? AllawShiftReportwithopenchecks { get; set; }

        public bool? DoesthisoutletusehandhelsPC { get; set; }

        public bool? AllawZeroCovers { get; set; }

        public bool? AllServersaccesstoallchecks { get; set; }

        public bool? Printsummaryonworkorders { get; set; }

        public bool? Defultisthisclubmembertoyes { get; set; }

        public bool? Printsignonoff { get; set; }

        public bool? UseFullScreenSystem { get; set; }

        public bool? UseKitchenMonitors { get; set; }

        public bool? UseItemList { get; set; }

        public bool? RunKitchenPrinterOnHoldCase { get; set; }

        public int? MainCourse { get; set; }

        [StringLength(50)]
        public string DefaultLang { get; set; }

        [StringLength(50)]
        public string Resolution { get; set; }

        [Column(TypeName = "image")]
        public byte[] MainPhoto { get; set; }

        [Column(TypeName = "image")]
        public byte[] LogoPhoto { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public bool? Assimbly_Kitchen { get; set; }

        public int? Assimbly_Printer { get; set; }

        public bool? Generate_Order_No { get; set; }

        public int? Min_Order_No { get; set; }

        public int? Max_Order_No { get; set; }

        public bool? PrntEndShiftPilotDet { get; set; }

        public bool? PrntRcpOrderFromAssimbly { get; set; }

        [StringLength(50)]
        public string CalcMinCharge { get; set; }

        [StringLength(50)]
        public string ChkDinIn { get; set; }

        [StringLength(50)]
        public string ChkHD { get; set; }

        [StringLength(50)]
        public string ChkTakeAway { get; set; }

        [StringLength(50)]
        public string ChkDriveThru { get; set; }

        [StringLength(50)]
        public string tableblankColor { get; set; }

        [StringLength(50)]
        public string tableuseColor { get; set; }

        [StringLength(50)]
        public string checkprintColor { get; set; }

        [StringLength(50)]
        public string checkcloseColor { get; set; }

        public int? BlankAfterClose { get; set; }

        public int? Preparation_Time { get; set; }

        public int? Printer_Invoice_ID { get; set; }

        public int? Print_Invoice_Count { get; set; }

        public bool? Allow_Reprint_Invoice { get; set; }

        public bool? Donot_Edit_Check_After_Print { get; set; }

        public bool? Used_Receipt_Pilot { get; set; }

        public bool? Can_Edit_Count_Close_Receipt_DinIn { get; set; }

        public bool? Print_Receipt_Order_No { get; set; }

        public bool? Count_Item_Serial { get; set; }

        public int? Item_ID_Serial { get; set; }

        public long? Start_Serial { get; set; }

        public int? PriceLVL_ID { get; set; }

        [StringLength(100)]
        public string Design_Receipt_Check { get; set; }

        public int? Recpt_Count_TAway { get; set; }

        public bool? Cater_InFirstDay { get; set; }

        public bool? Cater_InTimeOrder { get; set; }

        public int? MinutesCater { get; set; }

        public int? PriceLVL_ID_DinIn { get; set; }

        public int? PriceLVL_ID_HD { get; set; }

        public int? PriceLVL_ID_TAwy { get; set; }

        public int? PriceLVL_ID_DThru { get; set; }

        public bool? Auto_EndDay { get; set; }

        public int? End_After_Hour { get; set; }

        public bool? ShowFireOnlyTAway { get; set; }

        public bool? Fire_NewTAway { get; set; }

        public bool? Quick_Pay_CashTAway { get; set; }

        public bool? UsedFirstKitchenPrinterOnly { get; set; }

        public bool? Required_Visa_Batch_No { get; set; }

        public bool? Required_Visa_Expiry_Date { get; set; }

        public bool? Required_VisaNo { get; set; }

        public bool? Show_Complementary_On_Check { get; set; }

        public bool? Different_Serial_For_Officer { get; set; }

        public bool? Show_Officer_ON_Fast_Rpt { get; set; }

        public bool? Assign_Waiter_In_Take_Away { get; set; }

        public bool? ShowFire_HoldTAway { get; set; }

        public bool? MinCharge_ByTime { get; set; }

        public int? MinCharge_Start_Time { get; set; }

        public int? MinCharge_End_Time { get; set; }

        public int? Form_Lock { get; set; }

        public int? Recpt_Count_Dinin { get; set; }

        public bool? Manager_End_Day_Machine_Date { get; set; }

        [StringLength(150)]
        public string Manager_PW_End_Day { get; set; }

        public bool? Print_Direct_Check { get; set; }

        public bool? Print_Direct_Kitchen { get; set; }

        public bool? Print_Mod_Last_Item_on_Check { get; set; }

        public bool? Show_Price_On_Direct_Kit_Open_Price { get; set; }

        public bool? Show_Price_On_Direct_Kit_Open_Food { get; set; }

        public int? Menu_Items_Count { get; set; }

        public int? MinCharge_Tax_ID { get; set; }

        public double? Min_Order_Level { get; set; }

        public double? Target_Daily { get; set; }

        public double? Target_Week { get; set; }

        public double? Target_Month { get; set; }

        public bool? Security_Customer { get; set; }

        public bool? Security_Pilot { get; set; }

        public bool? Allow_No_Reason_Comp { get; set; }

        public bool? Allow_No_Reason_Void { get; set; }

        public bool? Allow_No_Reason_Discount { get; set; }

        public bool? Allow_Open_Check_WithoutItems_WithBalance { get; set; }
    }
}
