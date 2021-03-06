namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Process_BI_Child
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Process_BI_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FC_Item_ID { get; set; }

        public double? Perc_Qty { get; set; }

        public double? ProcessQty { get; set; }

        public double? Perc_Cost { get; set; }

        public double? UpdateCost { get; set; }

        public int? Serial { get; set; }
    }
}
