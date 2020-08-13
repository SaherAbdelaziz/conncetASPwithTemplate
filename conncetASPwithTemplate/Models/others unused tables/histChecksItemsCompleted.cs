namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("histChecksItemsCompleted")]
    public partial class histChecksItemsCompleted
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Check_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Serial { get; set; }

        public int? Ref_Mod_Item { get; set; }

        public bool? Completed { get; set; }

        public DateTime? Completed_Time { get; set; }

        public bool? Voided { get; set; }
    }
}
