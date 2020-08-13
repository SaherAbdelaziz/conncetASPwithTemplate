namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class End_Shift_User
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Log_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string User_Type { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rest_ID_Active { get; set; }

        public int? Checks_Count { get; set; }

        public int? Items_Count { get; set; }

        public int? Void_Checks_Count { get; set; }

        public double? Void_Checks_Value { get; set; }

        public int? Void_Items_Count { get; set; }

        public double? Void_Items_Value { get; set; }

        public double? SubTotal { get; set; }

        public double? Adjustments { get; set; }

        public double? Taxes { get; set; }

        public double? Discount { get; set; }

        public double? R_MinCharge { get; set; }

        public double? NetTotal { get; set; }

        public double? Tip { get; set; }

        public double? TotalAmount { get; set; }

        [Required]
        public string Checks_ID { get; set; }

        public double? Open_Drawer { get; set; }

        public double? Apply_Payment { get; set; }

        public double? PaidOut { get; set; }
    }
}
