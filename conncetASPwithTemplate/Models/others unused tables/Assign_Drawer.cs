namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Assign_Drawer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int Log_ID { get; set; }

        public int? User_ID { get; set; }

        public int? Drawer_ID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public DateTime? Open_Date { get; set; }

        public DateTime? Close_Date { get; set; }

        public double? Open_Amt { get; set; }

        public double? Close_Amt { get; set; }
    }
}
