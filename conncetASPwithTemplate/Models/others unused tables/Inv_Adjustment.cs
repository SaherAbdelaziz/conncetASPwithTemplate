namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inv_Adjustment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Inv_Adj_ID { get; set; }

        public int? Inv_Adj_No { get; set; }

        [StringLength(50)]
        public string Inv_Item_Type { get; set; }

        public int? Reason_ID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(200)]
        public string Notes { get; set; }

        public bool? Post { get; set; }

        public DateTime? PostedDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? OutLet_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? WS { get; set; }
    }
}
