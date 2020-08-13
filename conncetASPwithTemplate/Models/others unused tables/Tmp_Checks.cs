namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tmp_Checks
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CheckSerail { get; set; }

        [StringLength(50)]
        public string CheckTitel { get; set; }

        [StringLength(50)]
        public string CheckType { get; set; }

        public int? Covers { get; set; }

        [StringLength(50)]
        public string MyTable { get; set; }

        [StringLength(50)]
        public string MyCase { get; set; }

        [StringLength(50)]
        public string MyStatus { get; set; }

        public int? RefranceTo { get; set; }

        public DateTime? myDateTime { get; set; }

        public DateTime? OpenIn { get; set; }

        public DateTime? ClosedIn { get; set; }

        public int? Cust_ID { get; set; }

        public int? Server_ID { get; set; }

        public int? Casher_ID { get; set; }

        public int? Admin_ID { get; set; }

        public int? OutLet_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
