namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pre_Paid_Adjust
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrePaid_Adj_ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? Item_ID { get; set; }

        public bool? Post { get; set; }

        public DateTime? PostedDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }
    }
}
