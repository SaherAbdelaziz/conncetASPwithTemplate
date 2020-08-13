namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AR_Checks_Pay
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public long? Cust_ID { get; set; }

        public double? Amt { get; set; }

        public string AR_ID { get; set; }

        public bool? Voided { get; set; }

        public int? Voided_Reason { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? OutLet_ID_Active { get; set; }
    }
}
