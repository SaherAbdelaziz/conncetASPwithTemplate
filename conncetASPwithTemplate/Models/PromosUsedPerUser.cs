using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace conncetASPwithTemplate.Models
{
    public class PromosUsedPerUser
    {
        [Key]
        [Column(Order = 0)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int PromoId { get; set; }

        public ApplicationUser User { get; set; }
        public Promo Promo { get; set; }

        public int Count { get; set; }
    }
}