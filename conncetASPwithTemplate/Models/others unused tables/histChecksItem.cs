namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class histChecksItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Check_ID { get; set; }

        public int? Item_ID { get; set; }

        public float? QTY { get; set; }

        public double? UnitPrice { get; set; }

        public double? TotalPrice { get; set; }

        public double? DicountValue { get; set; }

        public double? Tax_Value { get; set; }

        public double? Adj_Value { get; set; }

        public double? NetPrice { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Serial { get; set; }

        public bool? Fired { get; set; }

        public DateTime? Fired_Time { get; set; }

        public bool? Voided { get; set; }

        public DateTime? Voided_Time { get; set; }

        public int? Voided_Reason { get; set; }

        public bool? P_On_Check { get; set; }

        public double? Complement { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public bool? IsModifier { get; set; }

        public int? Ref_Mod_Item { get; set; }

        public bool? IsAssimbly { get; set; }

        public int? Ref_Ass_Item { get; set; }

        public bool? Taxable { get; set; }

        public bool? NoServiceCharge { get; set; }

        public int? Num_Fired { get; set; }

        public int? Num_Print { get; set; }

        public int? Server_ID { get; set; }

        public bool? P_On_Report { get; set; }

        public long? Check_ID_Combine { get; set; }

        public int? Round_Check_Fired { get; set; }

        public bool? Void_Effect_Invn { get; set; }

        public int? Promo_ID { get; set; }

        public double? Orig_Price { get; set; }

        public double? Officer { get; set; }

        public int? Comp_Reason_ID { get; set; }

        public long? End_Serial_Count { get; set; }

        public int? Discount_ID { get; set; }

        public int? Disc_Reason_ID { get; set; }

        public bool? Hold { get; set; }

        public DateTime? Hold_Time { get; set; }

        public int? Voided_By { get; set; }

        public int? Comp_By { get; set; }

        public int? Disc_By { get; set; }

        public int? Preparation_Time { get; set; }

        [StringLength(100)]
        public string Disc_Reason_Comment { get; set; }

        [StringLength(100)]
        public string Comp_Reason_Comment { get; set; }

        [StringLength(100)]
        public string Void_Reason_Comment { get; set; }

        public int? ModifierGroup_ID { get; set; }

        public bool? Pick_Follow_Item_Qty { get; set; }

        public int? Modifier_Pick { get; set; }

        public bool? Pre_Paid_Card { get; set; }
    }
}
