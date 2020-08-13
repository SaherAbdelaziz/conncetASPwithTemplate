namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_EndDay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutLet_ID { get; set; }

        public bool? Log_Out_All_Users { get; set; }

        public bool? Prnt_Z_Out { get; set; }

        public bool? Prnt_Pilots { get; set; }

        public bool? Prnt_Pilots_Balance { get; set; }

        public bool? Prnt_Items_Sales { get; set; }

        public bool? Prnt_Qty_Sold { get; set; }

        public bool? Prnt_Daily_MOP { get; set; }

        public bool? Prnt_Inventory_Items { get; set; }

        public bool? Prnt_Cashier_Daily { get; set; }

        public bool? Prnt_All_Users_Shift { get; set; }
    }
}
