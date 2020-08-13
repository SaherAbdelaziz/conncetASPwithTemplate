namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Voucher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Vou_ID { get; set; }

        public int Vou_No { get; set; }

        [StringLength(50)]
        public string Vou_Type { get; set; }

        [StringLength(50)]
        public string Source_Type { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public long? Reverse { get; set; }

        public DateTime? ArrivalDate { get; set; }

        public int? Vend_ID { get; set; }

        public long? Process_BI_ID { get; set; }

        public long? Produce_Rcp_ID { get; set; }

        public long? PO_ID { get; set; }

        public long? Tran_ID { get; set; }

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
