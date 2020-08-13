namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Process_BI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Process_BI_ID { get; set; }

        public int? Process_No { get; set; }

        public DateTime? Process_Date { get; set; }

        public int? Invn_ID { get; set; }

        public int? Invn_Kit_ID { get; set; }

        public int? Bulk_Item_ID { get; set; }

        public double? OnHand { get; set; }

        public double? Process_Qty { get; set; }

        public int? Unit_ID { get; set; }

        public double? Cost { get; set; }

        public double? Yeld_Perc { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? User_ID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
