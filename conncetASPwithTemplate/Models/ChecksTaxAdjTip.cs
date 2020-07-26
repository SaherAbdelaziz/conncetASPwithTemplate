using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace conncetASPwithTemplate.Models
{


    [Table("ChecksTaxAdjTip")]
    public partial class ChecksTaxAdjTip
    {
        public int ID { get; set; }

        public long? Check_ID { get; set; }

        public int? AdjTax_ID { get; set; }

        public double? Perc_AdjTax { get; set; }

        public double? Value_AdjTax { get; set; }

        [StringLength(50)]
        public string theCase { get; set; }

        public bool? Voided { get; set; }
    }
}
