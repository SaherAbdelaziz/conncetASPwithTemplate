namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Design_DiningRooms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiningRoom_ID { get; set; }

        public int? Height { get; set; }

        public int? Width { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }
    }
}
