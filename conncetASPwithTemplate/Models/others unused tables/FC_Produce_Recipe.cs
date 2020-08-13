namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Produce_Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Produce_Rcp_ID { get; set; }

        public int? Produce_No { get; set; }

        public DateTime? Produce_Date { get; set; }

        public int? Invn_ID { get; set; }

        public int? Invn_Kit_ID { get; set; }

        public int? FC_Recipe_ID { get; set; }

        public double? Produce_Qty { get; set; }

        public int? Unit_ID { get; set; }

        public double? TotalCost { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? User_ID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
