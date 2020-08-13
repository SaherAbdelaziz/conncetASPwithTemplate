namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Update_Item_Price
    {
        public int ID { get; set; }

        public int Item_ID { get; set; }

        public int PriceLVL_ID { get; set; }

        public double? Price_Value { get; set; }

        public DateTime? Price_Date { get; set; }

        public int? User_ID { get; set; }
    }
}
