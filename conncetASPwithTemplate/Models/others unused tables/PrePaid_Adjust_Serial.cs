namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PrePaid_Adjust_Serial
    {
        public int PrePaid_Adj_ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PrePaid_Serial { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rest_ID_Active { get; set; }
    }
}
