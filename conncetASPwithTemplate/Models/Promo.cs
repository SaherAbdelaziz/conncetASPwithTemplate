using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace conncetASPwithTemplate.Models
{
    public class Promo
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public Discount Discount { get; set; }
        public int DiscountId { get; set; }
    }
}