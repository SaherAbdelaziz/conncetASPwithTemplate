namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Vou_Items
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Vou_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FC_Item_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FC_Recipe_ID { get; set; }

        public double? Qty_OnHand { get; set; }

        public double? Last_Cost { get; set; }

        public double? Qty { get; set; }

        public int? Unit_ID { get; set; }

        public double? Cost { get; set; }

        public double? Total_Cost { get; set; }

        public int? Serial { get; set; }

        public double? Inv_Qty_OnHand { get; set; }

        public double? Inv_Last_Cost { get; set; }

        public double? Inv_Qty { get; set; }

        public int? Inv_Unit_ID { get; set; }

        public double? Inv_Cost { get; set; }
    }
}
