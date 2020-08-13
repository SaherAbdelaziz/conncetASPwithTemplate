namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Invn_kit_Variance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Variance_ID { get; set; }

        public int? Variance_No { get; set; }

        public int? Adj_Reason_ID { get; set; }

        public DateTime? Variance_Date { get; set; }

        public long Sheet_ID { get; set; }

        public int? Invn_ID { get; set; }

        public int? Invn_Kit_ID { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? WS { get; set; }
    }
}
