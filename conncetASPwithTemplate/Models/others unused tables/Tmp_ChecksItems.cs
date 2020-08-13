namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tmp_ChecksItems
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int? CheckSerail { get; set; }

        public int? Item_ID { get; set; }

        public float? QTY { get; set; }

        public double? UnitPrice { get; set; }

        public double? TotalPrice { get; set; }

        public double? DicountValue { get; set; }

        public double? NetPrice { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Serial { get; set; }

        public int? Refrance_ID { get; set; }

        public bool? Fired { get; set; }

        public DateTime? Fired_Time { get; set; }

        public bool? Voided { get; set; }

        public DateTime? Voided_Time { get; set; }

        [StringLength(250)]
        public string Voided_Reason { get; set; }

        public DateTime? Completed_Time { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string myCase { get; set; }

        public int? Printer_ID { get; set; }

        [StringLength(50)]
        public string Complement { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public bool? IsModifier { get; set; }

        public int? Ref_Mod_Item { get; set; }

        public bool? IsAssimply { get; set; }

        public int? Ref_Ass_Item { get; set; }

        public bool? Taxable { get; set; }

        public bool? NoServiceCharge { get; set; }
    }
}
