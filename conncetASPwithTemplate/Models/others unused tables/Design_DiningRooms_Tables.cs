namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Design_DiningRooms_Tables
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Design_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Table_ID { get; set; }

        [StringLength(100)]
        public string Field_Font { get; set; }

        [StringLength(100)]
        public string Field_Location { get; set; }

        [StringLength(100)]
        public string Field_Size { get; set; }

        public int? Serial { get; set; }
    }
}
