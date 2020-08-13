namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shelfs")]
    public partial class Shelf
    {
        public int LocCode { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShelfCode { get; set; }

        [StringLength(50)]
        public string ShelfName { get; set; }
    }
}
