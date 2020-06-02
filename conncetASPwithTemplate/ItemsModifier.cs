using conncetASPwithTemplate.Models;

namespace conncetASPwithTemplate
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class ItemsModifier
    {
        [Key]
        [Column(Order = 0)]
        public int ItemId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ModifierId { get; set; }

        public Item Item { get; set; }
        public Modifier Modifier { get; set; }

        public bool? Active { get; set; }

        public int? Serial { get; set; }
    }
}
