namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Invn_kit_Sheet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Sheet_ID { get; set; }

        public int? Sheet_No { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? Invn_ID { get; set; }

        public int? Invn_Kit_ID { get; set; }

        public bool? Used { get; set; }

        public bool? Closed { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? WS { get; set; }
    }
}
