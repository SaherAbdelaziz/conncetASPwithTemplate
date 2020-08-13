namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Transfer_Items
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Tran_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FC_Item_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FC_Recipe_ID { get; set; }

        public double? QtyIss { get; set; }

        public double? QtyOnHand { get; set; }

        public double? QtySent { get; set; }

        public double? QtyRec { get; set; }

        public int? Unit_ID { get; set; }

        public double? Cost { get; set; }

        [StringLength(200)]
        public string Comment { get; set; }

        public int Serial { get; set; }

        public double? Inv_QtyIss { get; set; }

        public double? Inv_QtyOnHand { get; set; }

        public double? Inv_QtySent { get; set; }

        public double? Inv_QtyRec { get; set; }

        public int? Inv_Unit_ID { get; set; }

        public double? Inv_Cost { get; set; }
    }
}
