namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OutletSetup")]
    public partial class OutletSetup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutLetCode { get; set; }

        [StringLength(1000)]
        public string OutletName { get; set; }

        [StringLength(1000)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Merchant { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string OutletType { get; set; }

        [StringLength(50)]
        public string InputMethode { get; set; }

        [StringLength(50)]
        public string MaxdigitesLoonNumber { get; set; }

        [StringLength(50)]
        public string ServerscreenCheckSort { get; set; }

        [StringLength(50)]
        public string ServiceIDEntry { get; set; }

        [StringLength(50)]
        public string ManagerIDEntry { get; set; }

        [StringLength(50)]
        public string LogOnMoorButton { get; set; }

        [StringLength(50)]
        public string MusterCurrancy { get; set; }

        [StringLength(50)]
        public string Usetablecontrolsystem { get; set; }

        [StringLength(50)]
        public string Usealphanumarictable { get; set; }

        [StringLength(50)]
        public string ShowDroponShiftreport { get; set; }

        [StringLength(50)]
        public string Showoutofstockatlogon { get; set; }

        [StringLength(50)]
        public string Delayfirecapability { get; set; }

        [StringLength(50)]
        public string Allawserversopenallchecs { get; set; }

        [StringLength(50)]
        public string CheckLocing { get; set; }

        [StringLength(50)]
        public string AskbargustIDCovers { get; set; }

        [StringLength(50)]
        public string Usemultimodesscreen { get; set; }

        [StringLength(50)]
        public string Quicksaleloopback { get; set; }

        [StringLength(50)]
        public string fireOption { get; set; }

        [StringLength(50)]
        public string clcTaxes { get; set; }

        [StringLength(50)]
        public string InclusiveVatTax { get; set; }

        [StringLength(50)]
        public string AllawMultiCurrencySettlements { get; set; }

        [StringLength(50)]
        public string AllawTipEntryInSettlementScreen { get; set; }

        [StringLength(50)]
        public string AllawPartialPaymentOfChecks { get; set; }

        [StringLength(50)]
        public string CheckType { get; set; }

        [StringLength(50)]
        public string ItemsOrder { get; set; }

        [StringLength(50)]
        public string CheckPrinterType { get; set; }

        [StringLength(50)]
        public string ReciptDoNotPayWarning { get; set; }

        [StringLength(50)]
        public string TipLineonCheckCCSlip { get; set; }

        [StringLength(50)]
        public string PintmskedCCandexpirationdateongeneralrespit { get; set; }

        [StringLength(50)]
        public string PrintVatTaxrecaponroomsettlementrecpicts { get; set; }

        [StringLength(50)]
        public string AtomaticReceipt { get; set; }

        [StringLength(50)]
        public string PrintCheckasBarCode { get; set; }

        [StringLength(50)]
        public string TipCaptiononCheck { get; set; }

        [StringLength(50)]
        public string Signatureinfoline { get; set; }

        [StringLength(50)]
        public string ServerThankLine { get; set; }

        [StringLength(50)]
        public string LocalCurrancyRate { get; set; }

        [StringLength(50)]
        public string Hader1 { get; set; }

        [StringLength(50)]
        public string Hader2 { get; set; }

        [StringLength(50)]
        public string Hader3 { get; set; }

        [StringLength(50)]
        public string Hader4 { get; set; }

        [StringLength(50)]
        public string Hader5 { get; set; }

        [StringLength(50)]
        public string Footer1 { get; set; }

        [StringLength(50)]
        public string Footer2 { get; set; }

        [StringLength(50)]
        public string Footer3 { get; set; }

        [StringLength(50)]
        public string Footer4 { get; set; }

        [StringLength(50)]
        public string Footer5 { get; set; }

        [StringLength(50)]
        public string AllawShiftReportwithopenchecks { get; set; }

        [StringLength(50)]
        public string DoesthisoutletusehandhelsPC { get; set; }

        [StringLength(50)]
        public string AllawZeroCovers { get; set; }

        [StringLength(50)]
        public string AllServersaccesstoallchecks { get; set; }

        [StringLength(50)]
        public string Printsummaryonworkorders { get; set; }

        [StringLength(50)]
        public string Defultisthisclubmembertoyes { get; set; }

        [StringLength(50)]
        public string Printsignonoff { get; set; }

        [StringLength(50)]
        public string Usecustomkeyconfiguration { get; set; }

        [StringLength(50)]
        public string AutoadvancedSeatnumbers { get; set; }

        [StringLength(50)]
        public string TrackMaleFemale { get; set; }

        [StringLength(50)]
        public string SortbygustonOrderScreen { get; set; }

        [StringLength(50)]
        public string AskseatonQTYOrder { get; set; }

        [StringLength(50)]
        public string AskChecktipatlogoff { get; set; }

        public int? MainPreseteCode { get; set; }

        [StringLength(500)]
        public string MainPhoto { get; set; }

        [StringLength(522)]
        public string Logo { get; set; }

        [Column(TypeName = "image")]
        public byte[] LogoVlue { get; set; }

        public int? ChickPrinter { get; set; }

        [StringLength(50)]
        public string Option1 { get; set; }

        [StringLength(50)]
        public string Option2 { get; set; }

        [StringLength(50)]
        public string Option3 { get; set; }

        [StringLength(50)]
        public string Option4 { get; set; }

        [StringLength(50)]
        public string Option5 { get; set; }

        [StringLength(50)]
        public string Option6 { get; set; }

        [StringLength(50)]
        public string Option7 { get; set; }

        [StringLength(50)]
        public string Option8 { get; set; }

        [StringLength(50)]
        public string Option9 { get; set; }

        [StringLength(50)]
        public string Option10 { get; set; }

        [StringLength(50)]
        public string Option11 { get; set; }

        [StringLength(50)]
        public string Option12 { get; set; }

        [StringLength(50)]
        public string Option13 { get; set; }

        [StringLength(50)]
        public string Option14 { get; set; }

        [StringLength(50)]
        public string Option15 { get; set; }

        [StringLength(50)]
        public string Option16 { get; set; }

        [StringLength(50)]
        public string Option17 { get; set; }

        [StringLength(50)]
        public string Option18 { get; set; }

        [StringLength(50)]
        public string Option19 { get; set; }

        [StringLength(50)]
        public string Option20 { get; set; }

        [StringLength(50)]
        public string SetPrinterLangugeAccordingTo { get; set; }

        [StringLength(1000)]
        public string AssemblerPath { get; set; }

        [StringLength(50)]
        public string Option21 { get; set; }

        [StringLength(50)]
        public string Option22 { get; set; }

        [StringLength(50)]
        public string Option23 { get; set; }

        [StringLength(50)]
        public string Option24 { get; set; }

        [StringLength(50)]
        public string Option25 { get; set; }

        [StringLength(50)]
        public string Option26 { get; set; }

        [StringLength(50)]
        public string Option27 { get; set; }

        [StringLength(50)]
        public string Option28 { get; set; }

        [StringLength(50)]
        public string Option29 { get; set; }

        [StringLength(50)]
        public string Option30 { get; set; }

        [StringLength(50)]
        public string Option31 { get; set; }

        [StringLength(50)]
        public string Option32 { get; set; }

        [StringLength(50)]
        public string Option33 { get; set; }

        [StringLength(50)]
        public string Option34 { get; set; }

        [StringLength(50)]
        public string Option35 { get; set; }

        [StringLength(50)]
        public string Option36 { get; set; }

        [StringLength(50)]
        public string Option37 { get; set; }

        [StringLength(50)]
        public string Option38 { get; set; }

        [StringLength(50)]
        public string Option39 { get; set; }

        [StringLength(50)]
        public string Option40 { get; set; }
    }
}
