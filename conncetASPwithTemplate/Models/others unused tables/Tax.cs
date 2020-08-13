namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tax
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Name2 { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(50)]
        public string taxType { get; set; }

        public double? taxValue { get; set; }

        public int? MinimumPersonToClc { get; set; }

        public bool? Timed { get; set; }

        [StringLength(50)]
        public string tFrom { get; set; }

        [StringLength(50)]
        public string tTo { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public bool? SetDefault { get; set; }

        public bool? For_Each_Cover { get; set; }
    }
}
