using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conncetASPwithTemplate.Models
{
    public class ItemsModifier
    {
        [Key]
        [Column(Order = 0)]
        public int ItemId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ModifiersGroupId { get; set; }

        public Item Item { get; set; }
        public ModifiersGroup ModifiersGroup { get; set; }

        public bool? Active { get; set; }

        public int? Serial { get; set; }
    }
}
