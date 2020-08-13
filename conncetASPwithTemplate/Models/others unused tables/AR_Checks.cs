namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AR_Checks
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TypeAR { get; set; }

        public long? Check_ID { get; set; }

        public long? Cust_ID { get; set; }

        public int? Cashier_Credit { get; set; }

        [StringLength(500)]
        public string GuestName { get; set; }

        public DateTime? myDate { get; set; }

        public double? TotalAmount { get; set; }

        public double? TotalPaid { get; set; }

        public double? RiminingAmount { get; set; }

        [StringLength(50)]
        public string Paid { get; set; }

        public bool? Voided { get; set; }

        public int? Voided_Reason { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? OutLet_ID_Active { get; set; }
    }
}
