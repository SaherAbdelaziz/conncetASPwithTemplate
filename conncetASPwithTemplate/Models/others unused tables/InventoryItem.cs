namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InventoryItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(50)]
        public string Name1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Name2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Desc { get; set; }

        public int? UsageUnit { get; set; }

        public int? StockedUnit { get; set; }

        public int? CategoryCode { get; set; }

        public int? SubCategoryCode { get; set; }

        [StringLength(50)]
        public string Yield { get; set; }
    }
}
