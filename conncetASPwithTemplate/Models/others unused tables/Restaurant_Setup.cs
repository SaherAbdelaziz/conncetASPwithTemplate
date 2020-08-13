namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Restaurant_Setup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rest_ID { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(100)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string CataringPrintCase { get; set; }

        public bool? CalcAdjBeforeDisc { get; set; }

        public bool? CalcTaxBeforeDisc { get; set; }

        public bool? CalcDiscOnNetTotal { get; set; }

        public bool? InclusiveVatTax { get; set; }

        public bool? AllawMultiCurrencySettlement { get; set; }

        public bool? AllawTipEntryInSettlementScreen { get; set; }

        public bool? AllawPartialPaymentOfCheck { get; set; }

        public bool? RemoveMultiPayment { get; set; }

        [StringLength(50)]
        public string PrinterLang { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }
    }
}
