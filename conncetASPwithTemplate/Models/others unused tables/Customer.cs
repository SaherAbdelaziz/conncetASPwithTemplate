namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Adress { get; set; }

        [StringLength(300)]
        public string Adress2 { get; set; }

        public int? Company_ID { get; set; }

        public int? Area_ID { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(100)]
        public string From_Street { get; set; }

        [StringLength(50)]
        public string Building { get; set; }

        [StringLength(50)]
        public string Floor { get; set; }

        [StringLength(50)]
        public string apartment { get; set; }

        [StringLength(100)]
        public string Special_Mark { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public bool? AR { get; set; }

        public double? CreditLimit { get; set; }

        public bool? FrequentGust { get; set; }

        public bool? AcceptLatePayments { get; set; }

        public int? Discount_ID { get; set; }

        public bool? Block { get; set; }

        [StringLength(250)]
        public string Reason_Block { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        [StringLength(50)]
        public string AR_No { get; set; }

        [Column(TypeName = "image")]
        public byte[] Signature { get; set; }

        [StringLength(250)]
        public string Notes { get; set; }

        [StringLength(100)]
        public string PassCode { get; set; }
    }
}
