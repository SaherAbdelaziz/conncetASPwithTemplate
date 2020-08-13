namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recipe")]
    public partial class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Name2 { get; set; }

        public int? CrossCode { get; set; }

        public int? Qty { get; set; }

        public int? UnitCode { get; set; }

        [StringLength(50)]
        public string Comment { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCost { get; set; }
    }
}
