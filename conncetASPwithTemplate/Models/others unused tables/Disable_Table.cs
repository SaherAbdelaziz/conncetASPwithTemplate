namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Disable_Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Table_ID { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? User_ID { get; set; }
    }
}
