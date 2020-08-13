namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Main_OutLet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(200)]
        public string Main_Rest { get; set; }

        [Column("Main_OutLet")]
        [StringLength(200)]
        public string Main_OutLet1 { get; set; }
    }
}
