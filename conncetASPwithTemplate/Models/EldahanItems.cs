using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace conncetASPwithTemplate.Models
{
    public class EldahanItems
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Name2 { get; set; }

        [StringLength(50)]
        public string BarCode { get; set; }

        public int? CrossCode { get; set; }

        public bool? Taxable { get; set; }

        public bool? Assimbly { get; set; }

        public Web_Preset EldahanPreset { get; set; }
        public int EldahanPresetId { get; set; }

        public bool? IsModifier { get; set; }

        public bool? StandAlone { get; set; }

        public bool? PrintOnChick { get; set; }

        public bool? PrintOnReport { get; set; }

        public bool? FollowItem { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image_Item { get; set; }

        [StringLength(50)]
        public string BackColor { get; set; }

        [StringLength(50)]
        public string fontColor { get; set; }

        public double? Cost { get; set; }

        public bool? OpenPrice { get; set; }

        public double? StaticPrice { get; set; }

        [StringLength(200)]
        public string Description1 { get; set; }

        [StringLength(200)]
        public string Description2 { get; set; }

        [StringLength(200)]
        public string Description3 { get; set; }

        [StringLength(200)]
        public string Description4 { get; set; }

        public bool? ModPrice_0 { get; set; }

        [StringLength(50)]
        public string ItemFont { get; set; }

        public bool? UseItemTimer { get; set; }

        public int? ItemTimerValue { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public bool? NoServiceCharge { get; set; }

        public bool? Market_Price { get; set; }

        public bool? Item_Track { get; set; }

        public bool? PrintItemOnCheck { get; set; }

        public bool? IsParent { get; set; }

        public int? Rest_ID_Active { get; set; }

        public bool? Open_Food { get; set; }

        public double? Mod_Price { get; set; }

        public bool? Pre_Paid_Card { get; set; }

        public bool WebOrder { get; set; }
    }
}