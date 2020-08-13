namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Change_Server
    {
        public int ID { get; set; }

        public long? Check_ID { get; set; }

        public int? Old_Server_ID { get; set; }

        public int? New_Server_ID { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? User_ID { get; set; }
    }
}
