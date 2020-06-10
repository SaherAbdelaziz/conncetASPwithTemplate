using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace conncetASPwithTemplate.Models
{
    public class WebMenuItem
    {
        [Required]
        [Key]
        public int SerialId { get; set; }

        public int? ItemId { get; set; }
        public int? SortNumber { get; set; }
        public int? PresetId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? UserId { get; set; }
        public int? RestIdActive { get; set; }
        public int? OutLetIdActive { get; set; }


        public Item Item { get; set; }
        public WebPreset Preset { get; set; }

    }
}