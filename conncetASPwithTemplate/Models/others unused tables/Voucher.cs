namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Voucher")]
    public partial class Voucher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? Code { get; set; }

        public int? Vou_Type { get; set; }

        public int? Vend_Id { get; set; }

        public DateTime? Vou_Date { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(1)]
        public string Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_Id { get; set; }

        [StringLength(50)]
        public string Invc_No { get; set; }

        [StringLength(10)]
        public string MOP { get; set; }

        public DateTime? Due_Date { get; set; }

        [StringLength(2)]
        public string Paid { get; set; }

        [StringLength(50)]
        public string Reff_No { get; set; }
    }
}
