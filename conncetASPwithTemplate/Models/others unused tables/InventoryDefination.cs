namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryDefination")]
    public partial class InventoryDefination
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(50)]
        public string Name1 { get; set; }

        [StringLength(50)]
        public string Name2 { get; set; }

        [StringLength(1)]
        public string IsMain { get; set; }

        [StringLength(1)]
        public string IsOutlet { get; set; }
    }
}
