namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cat_histChecks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CheckSerail { get; set; }

        [StringLength(50)]
        public string CheckTitel { get; set; }

        [StringLength(50)]
        public string CheckType { get; set; }

        public int? Covers { get; set; }

        [StringLength(50)]
        public string myTable { get; set; }

        public int? ServerCode { get; set; }

        public int? OutletCode { get; set; }

        [StringLength(50)]
        public string myCase { get; set; }

        [StringLength(50)]
        public string myStatus { get; set; }

        public int? RefranceTo { get; set; }

        public int? PeriodCode { get; set; }

        public DateTime? myDateTime { get; set; }

        [StringLength(50)]
        public string OpenIn { get; set; }

        [StringLength(50)]
        public string ClosedIn { get; set; }

        public int? CasherCode { get; set; }

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
        public string Col1 { get; set; }

        [StringLength(50)]
        public string Col2 { get; set; }

        [StringLength(50)]
        public string Col3 { get; set; }

        [StringLength(50)]
        public string Col4 { get; set; }

        [StringLength(50)]
        public string Col5 { get; set; }

        [StringLength(50)]
        public string Col6 { get; set; }

        [StringLength(50)]
        public string Col7 { get; set; }

        [StringLength(50)]
        public string Col8 { get; set; }

        [StringLength(50)]
        public string Col9 { get; set; }

        [StringLength(50)]
        public string Col10 { get; set; }

        public int? CustCode { get; set; }

        public int? Code1 { get; set; }

        public int? Code2 { get; set; }

        public int? Code3 { get; set; }

        public int? Code4 { get; set; }

        public int? Code5 { get; set; }
    }
}
