namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Point
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool? Remove_When_Disc { get; set; }

        public int? Start_Point { get; set; }

        public int? Max_Point { get; set; }

        public int? Valid_Days { get; set; }

        [StringLength(250)]
        public string Notes { get; set; }

        public bool? Cancel { get; set; }

        public DateTime? CancelledDate { get; set; }

        public int? Cancelled_By { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? OutLet_ID { get; set; }

        public int? Rest_ID_Active { get; set; }
    }
}
