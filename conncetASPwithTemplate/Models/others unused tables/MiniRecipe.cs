namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MiniRecipe")]
    public partial class MiniRecipe
    {
        [Key]
        public int Code { get; set; }

        public int? RecipeCode { get; set; }

        public int? MiniRecCode { get; set; }

        public int? Qulity { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalMiniCost { get; set; }
    }
}
