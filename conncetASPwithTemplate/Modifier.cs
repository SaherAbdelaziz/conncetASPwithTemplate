using conncetASPwithTemplate.Models;

namespace conncetASPwithTemplate
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Modifier
    {
        [Key]
        [Column(Order = 0)]
        public int ModifiersGroupId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ItemId { get; set; }


        public ModifiersGroup ModifiersGroup { get; set; }
        public Item Item { get; set; }

        public int? IndexItem { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? UserID { get; set; }
    }
}
