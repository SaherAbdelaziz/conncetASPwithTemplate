using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class Promo
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public Discount Discount { get; set; }
        public int DiscountId { get; set; }

        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int MaxUseingTimes { get; set; }
    }
}