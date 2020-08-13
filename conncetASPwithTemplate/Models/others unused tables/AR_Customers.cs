namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AR_Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Cust_ID { get; set; }

        public double? AR_Value { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }
    }
}
