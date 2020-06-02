namespace conncetASPwithTemplate
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class HD_Areas_Services
    {
        [Key]
        [Column(Order = 0)]
        public int AreaId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int OutLetId { get; set; }

        public HD_Areas Area { get; set; }
        public OutLet OutLet { get; set; }

        public double? Services { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }
    }
}
