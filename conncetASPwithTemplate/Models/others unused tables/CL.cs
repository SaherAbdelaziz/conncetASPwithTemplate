namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CL")]
    public partial class CL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Dept_ID { get; set; }

        [StringLength(250)]
        public string Notes { get; set; }

        public double? Allow_Balance_Month { get; set; }

        public int? begin_Month { get; set; }

        public bool? Block { get; set; }

        [StringLength(250)]
        public string Reason_Block { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? Discount_ID { get; set; }
    }
}
