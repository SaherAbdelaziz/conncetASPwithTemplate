using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.Models
{
    public class Web_Preset
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Name2 { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [Column(TypeName = "image")]
        public byte[] ImagePreset { get; set; }
        public bool? Active { get; set; }

        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? UserId { get; set; }
        public int? RestIdActive { get; set; }
        public int? OutLetIdActive { get; set; }
        public bool? ByTime { get; set; }
        public int? StartTime { get; set; }
        public int? EndTime { get; set; }
    }
}