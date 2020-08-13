namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VersionDB")]
    public partial class VersionDB
    {
        public int ID { get; set; }

        public double? Ver_DB { get; set; }
    }
}
