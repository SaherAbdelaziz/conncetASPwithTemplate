using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace conncetASPwithTemplate.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public bool Removed { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }
    }
}