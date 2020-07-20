using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class OrderedItem
    {
        [Key]
        [Column(Order = 0)]
        public int ItemId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int OrderId { get; set; }

        public EldahanItems Item { get; set; }
        public Order Order { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool Ordered { get; set; }
    }
}