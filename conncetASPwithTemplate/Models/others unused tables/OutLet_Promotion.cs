namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OutLet_Promotion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutLet_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Promo_ID { get; set; }

        public bool? FastFood { get; set; }

        public bool? HD { get; set; }

        public bool? DinIn { get; set; }

        public bool? DriveThru { get; set; }

        public bool? Cataring { get; set; }
    }
}
