namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Items
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FC_Item_ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Cross_Code { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Name2 { get; set; }

        [StringLength(30)]
        public string BarCode { get; set; }

        public int? Cat_ID { get; set; }

        public int? SCat_ID { get; set; }

        public double? Cost { get; set; }

        public int? Unit_ID { get; set; }

        public int? Using_Unit_ID { get; set; }

        public int? Pur_Unit_ID { get; set; }

        public bool? Parent_Item { get; set; }

        public bool? Bulk_Item { get; set; }

        public bool? Hot_Item { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }
    }
}
