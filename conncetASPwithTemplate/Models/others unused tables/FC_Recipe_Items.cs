namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Recipe_Items
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FC_Recipe_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FC_Item_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FC_Sub_Recipe_ID { get; set; }

        public double? Qty { get; set; }

        public int? Unit_ID { get; set; }

        public double? Cost { get; set; }

        public double? Total_Cost { get; set; }

        public double? Cost_Perc { get; set; }

        public int? Serial { get; set; }

        public bool? Packing_List { get; set; }
    }
}
