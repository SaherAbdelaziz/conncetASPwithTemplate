namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Adjustment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Adj_ID { get; set; }

        public int Adj_No { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Source_Type { get; set; }

        public DateTime? Adj_Date { get; set; }

        public int? Adj_Reason_ID { get; set; }

        public long? Variance_ID { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public bool? Post { get; set; }

        public DateTime? PostedDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Invn_ID { get; set; }

        public int? Invn_Kit_ID { get; set; }

        public int? WS { get; set; }
    }
}
