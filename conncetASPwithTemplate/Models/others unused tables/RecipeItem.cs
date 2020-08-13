namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RecipeItem
    {
        public int ID { get; set; }

        public int RecCode { get; set; }

        public int? ItemCode { get; set; }

        public int? CatCode { get; set; }

        public int? SubCode { get; set; }

        public int? UnitCode { get; set; }

        public int? Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        public decimal? CostPer { get; set; }
    }
}
