namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VoucherItem
    {
        public int Id { get; set; }

        public int? Items_Id { get; set; }

        public int? Vou_Id { get; set; }

        public int? Qty { get; set; }

        public double? Cost { get; set; }

        public double? TotalCost { get; set; }
    }
}
