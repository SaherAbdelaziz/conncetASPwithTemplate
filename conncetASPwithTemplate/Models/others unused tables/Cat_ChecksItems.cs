namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cat_ChecksItems
    {
        public int? CheckCode { get; set; }

        public int? ItemCode { get; set; }

        [StringLength(50)]
        public string UnitPrice { get; set; }

        public float? QTY { get; set; }

        [StringLength(50)]
        public string TotalPrice { get; set; }

        public int? PeriodCode { get; set; }

        [StringLength(50)]
        public string myCase { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RtfSerial { get; set; }

        public int? RefranceCode { get; set; }

        [StringLength(50)]
        public string DicountValue { get; set; }

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

        public int? OutletCode { get; set; }

        [StringLength(50)]
        public string CheckType { get; set; }
    }
}
