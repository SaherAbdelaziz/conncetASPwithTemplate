namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class histChecksItemsSettle
    {
        public int ID { get; set; }

        public long Check_ID { get; set; }

        public int? MOP_ID { get; set; }

        public double? theValue { get; set; }

        [StringLength(50)]
        public string Serials { get; set; }

        public DateTime? EpirDate { get; set; }

        public int? Officer_ID { get; set; }

        public bool? Voided { get; set; }

        public int? Voided_Reason { get; set; }

        public int? Voided_By { get; set; }

        public int? CL_ID { get; set; }

        public int? Batch_No { get; set; }

        [StringLength(100)]
        public string Void_Reason_Comment { get; set; }
    }
}
