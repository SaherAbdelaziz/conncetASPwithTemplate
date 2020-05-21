using System;
using System.ComponentModel.DataAnnotations;

namespace conncetASPwithTemplate.Models
{
    public class SubCategory
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Name2 { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? UserId { get; set; }
        
    }
}
