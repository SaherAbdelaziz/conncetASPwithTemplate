using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPanel.Dtos
{
    public class CartItemDto
    {
        //public int Id { get; set; }

        public int CartId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public bool Removed { get; set; }

        public string Details { get; set; }

        public int ItemId { get; set; }

        public List<int> ItemsId { get; set; }

        public long CheckId { get; set; }
    }
}