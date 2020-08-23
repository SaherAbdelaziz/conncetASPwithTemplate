using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ViewModels;

namespace AdminPanel.Models
{
    public class Item
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Name2 { get; set; }

        [StringLength(50)]
        public string BarCode { get; set; }

        public int? CrossCode { get; set; }

        public bool? Taxable { get; set; }

        public bool? Assimbly { get; set; }

        public Web_Preset WebPreset { get; set; }
        public int WebPresetId { get; set; }

        [Required]
        public bool? IsModifier { get; set; }

        [Required]
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

        [Required]
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

        [Required]
        public bool WebOrder { get; set; }
        [Required]
        public bool Listed { get; set; }
        [Required]
        public int Available { get; set; }

        public Item()
        {
            
        }

        public Item(ItemViewModel model)
        {
            Code = model.Code;
            Name = model.Name;
            Name2 = model.Name2;
            BarCode = model.BarCode;
            CrossCode = model.CrossCode;
            Taxable = model.Taxable;
            Assimbly = model.Assimbly;
            WebPreset = model.EldahanPreset;
            WebPresetId = model.EldahanPresetId;
            IsModifier = model.IsModifier;
            StandAlone = model.StandAlone;
            PrintOnChick = model.PrintOnChick;
            PrintOnReport = model.PrintOnReport;
            FollowItem = model.FollowItem;
            Image_Item = model.Image_Item;
            BackColor = model.BackColor;
            this.fontColor = model.fontColor;
            Cost = model.Cost;
            OpenPrice = model.OpenPrice;
            StaticPrice = model.StaticPrice;
            Description1 = model.Description1;
            Description2 = model.Description2;
            Description3 = model.Description3;
            Description4 = model.Description4;
            ModPrice_0 = model.ModPrice_0;
            ItemFont = model.ItemFont;
            UseItemTimer = model.UseItemTimer;
            ItemTimerValue = model.ItemTimerValue;
            Active = model.Active;
            CreateDate = model.CreateDate;
            ModifiedDate = model.ModifiedDate;
            User_ID = model.User_ID;
            NoServiceCharge = model.NoServiceCharge;
            Market_Price = model.Market_Price;
            Item_Track = model.Item_Track;
            PrintItemOnCheck = model.PrintItemOnCheck;
            IsParent = model.IsParent;
            Rest_ID_Active = model.Rest_ID_Active;
            Open_Food = model.Open_Food;
            Mod_Price = model.Mod_Price;
            Pre_Paid_Card = model.Pre_Paid_Card;
            WebOrder = model.WebOrder;
            Listed = model.Listed;
            Available = (int) model.Available;
        }

        public void Update(ItemViewModel model)
        {
            Code = model.Code;
            Name = model.Name;
            Name2 = model.Name2;
            BarCode = model.BarCode;
            CrossCode = model.CrossCode;
            Taxable = model.Taxable;
            Assimbly = model.Assimbly;
            WebPreset = model.EldahanPreset;
            WebPresetId = model.EldahanPresetId;
            IsModifier = model.IsModifier;
            StandAlone = model.StandAlone;
            PrintOnChick = model.PrintOnChick;
            PrintOnReport = model.PrintOnReport;
            FollowItem = model.FollowItem;
            Image_Item = model.Image_Item;
            BackColor = model.BackColor;
            this.fontColor = model.fontColor;
            Cost = model.Cost;
            OpenPrice = model.OpenPrice;
            StaticPrice = model.StaticPrice;
            Description1 = model.Description1;
            Description2 = model.Description2;
            Description3 = model.Description3;
            Description4 = model.Description4;
            ModPrice_0 = model.ModPrice_0;
            ItemFont = model.ItemFont;
            UseItemTimer = model.UseItemTimer;
            ItemTimerValue = model.ItemTimerValue;
            Active = model.Active;
            CreateDate = model.CreateDate;
            ModifiedDate = model.ModifiedDate;
            User_ID = model.User_ID;
            NoServiceCharge = model.NoServiceCharge;
            Market_Price = model.Market_Price;
            Item_Track = model.Item_Track;
            PrintItemOnCheck = model.PrintItemOnCheck;
            IsParent = model.IsParent;
            Rest_ID_Active = model.Rest_ID_Active;
            Open_Food = model.Open_Food;
            Mod_Price = model.Mod_Price;
            Pre_Paid_Card = model.Pre_Paid_Card;
            WebOrder = model.WebOrder;
            Listed = model.Listed;
            Available = (int)model.Available;
        }
    }
}