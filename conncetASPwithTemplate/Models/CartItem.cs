using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public string Details { get; set; }
        public bool HasModifiers { get; set; }
        public bool Ordered { get; set; }
        public int ItemId { get; set; }

        public EldahanItems Item { get; set; }


        public int OrderId { get; set; }

        //public int OrderId { get; set; }
        //public Order Order { get; set; }
    }
}