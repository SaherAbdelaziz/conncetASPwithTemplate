using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace conncetASPwithTemplate.Models
{
    
    [Table("ChecksItemsSettlesSummary")]
    public partial class ChecksItemsSettlesSummary
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Check_ID { get; set; }

        public double? SubTotal { get; set; }

        public double? Taxes { get; set; }

        public bool? VoidTaxes { get; set; }

        public double? Adjustments { get; set; }

        public bool? VoidAdjustments { get; set; }

        public double? Discount { get; set; }

        public double? ChangeValue { get; set; }

        public double? R_MinCharge { get; set; }

        public bool? VoidR_MinCharge { get; set; }

        public double? NetTotal { get; set; }

        public double? Tip { get; set; }

        public double? TotalAmount { get; set; }

        public double? TotalPaid { get; set; }

        public double? RiminingAmount { get; set; }

        public double? MinCharge { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Voided { get; set; }

        public int? Discount_ID { get; set; }

        public int? MOP_ID { get; set; }

        public int? Disc_Reason_ID { get; set; }

        public int? Disc_By { get; set; }

        public double? Set_MinCharge_One_Cover { get; set; }

        [StringLength(100)]
        public string Disc_Reason_Comment { get; set; }

        public ChecksItemsSettlesSummary()
        {
            
        }

        public ChecksItemsSettlesSummary(long checkId, double? subTotal, double? taxes, bool? voidTaxes, double? adjustments, bool? voidAdjustments, double? discount, double? changeValue, double? rMinCharge, bool? voidRMinCharge, double? netTotal, double? tip, double? totalAmount, double? totalPaid, double? riminingAmount, double? minCharge, bool voided)
        {
            Check_ID = checkId;
            SubTotal = subTotal;
            Taxes = taxes;
            VoidTaxes = voidTaxes;
            Adjustments = adjustments;
            VoidAdjustments = voidAdjustments;
            Discount = discount;
            ChangeValue = changeValue;
            R_MinCharge = rMinCharge;
            VoidR_MinCharge = voidRMinCharge;
            NetTotal = netTotal;
            Tip = tip;
            TotalAmount = totalAmount;
            TotalPaid = totalPaid;
            RiminingAmount = riminingAmount;
            MinCharge = minCharge;
            Voided = voided;
        }
    }
}
