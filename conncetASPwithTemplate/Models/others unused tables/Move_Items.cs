namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Move_Items
    {
        public int ID { get; set; }

        public int Item_ID { get; set; }

        public long From_Check_ID { get; set; }

        public long? To_Check_ID { get; set; }

        public double? Qty { get; set; }

        public DateTime? Move_Date { get; set; }

        public int? User_ID { get; set; }
    }
}
