namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaidOut_Tranactions
    {
        public int ID { get; set; }

        public int Paid_ID { get; set; }

        public DateTime? Paid_Date { get; set; }

        [StringLength(50)]
        public string RefNumber { get; set; }

        public double? Paid_Amount { get; set; }

        [StringLength(500)]
        public string Paid_Desc { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? OutLet_ID_Active { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? WS { get; set; }

        public bool? Voided { get; set; }

        public DateTime? Voided_Time { get; set; }

        public int? Voided_Reason { get; set; }
    }
}
