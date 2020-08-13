namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemDate")]
    public partial class SystemDate
    {
        public int ID { get; set; }

        public DateTime? SysDate { get; set; }

        public DateTime? Start_Time { get; set; }

        public DateTime? End_Time { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? OutLet_ID_Active { get; set; }
    }
}
