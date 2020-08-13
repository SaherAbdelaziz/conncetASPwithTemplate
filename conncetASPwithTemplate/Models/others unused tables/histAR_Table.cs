namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class histAR_Table
    {
        [Key]
        public int Serial { get; set; }

        [StringLength(50)]
        public string TypeAR { get; set; }

        public int? Cheek { get; set; }

        public int? GustCode { get; set; }

        [StringLength(500)]
        public string GustName { get; set; }

        public DateTime? myDate { get; set; }

        [StringLength(50)]
        public string TimeClose { get; set; }

        public float? myValue { get; set; }

        public float? Remain { get; set; }

        [StringLength(50)]
        public string Paid { get; set; }

        [StringLength(10)]
        public string Col1 { get; set; }

        [StringLength(10)]
        public string Col2 { get; set; }

        [StringLength(10)]
        public string Col3 { get; set; }

        [StringLength(10)]
        public string Col4 { get; set; }

        [StringLength(10)]
        public string Col5 { get; set; }

        [StringLength(10)]
        public string Col6 { get; set; }

        [StringLength(10)]
        public string Col7 { get; set; }

        [StringLength(10)]
        public string Col8 { get; set; }

        [StringLength(10)]
        public string Col9 { get; set; }

        [StringLength(10)]
        public string Col10 { get; set; }
    }
}
