namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Bulk_Items
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bulk_Item_ID { get; set; }

        public double? Yeld_Perc { get; set; }

        public bool? Active { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }
    }
}
