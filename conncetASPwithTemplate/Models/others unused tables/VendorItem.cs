namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VendorItem
    {
        public int Id { get; set; }

        public int? Items_Id { get; set; }

        public int? Vend_Id { get; set; }

        public double? Cost { get; set; }

        [StringLength(150)]
        public string Comment { get; set; }
    }
}
