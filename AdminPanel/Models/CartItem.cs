using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }
        public int Serial { get; set; }
        public DateTime DateCreated { get; set; }

        public bool Removed { get; set; }
        public string Details { get; set; }
        public bool HasModifiers { get; set; }
        public int ModifiersCount { get; set; }
        public bool Ordered { get; set; }
        public int OrderId { get; set; }
        public double Delivery { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int ShoppingCartId { get; set; }
        public Cart ShoppingCart { get; set; }
    }
}