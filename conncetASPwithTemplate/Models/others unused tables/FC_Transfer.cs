namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Transfer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Tran_ID { get; set; }

        public int? Tran_No { get; set; }

        [StringLength(50)]
        public string Tran_Type { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public DateTime? Tran_Date { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public bool? Received { get; set; }

        public int? From_Invn_ID { get; set; }

        public int? From_Invn_Kit_ID { get; set; }

        public int? To_Invn_ID { get; set; }

        public int? To_Invn_Kit_ID { get; set; }

        public long? Iss_ID { get; set; }

        public long? Return_Tran_ID { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public bool? Post { get; set; }

        public DateTime? PostedDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Received_UserID { get; set; }

        public int? WS { get; set; }
    }
}
