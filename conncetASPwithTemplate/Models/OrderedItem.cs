using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace conncetASPwithTemplate.Models
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
        public string Details { get; set; }


        public OrderedItem()
        {
            
        }

        public OrderedItem(int itemId, int orderId, EldahanItems item, Order order, int quantity, int price, bool ordered , string details)
        {
            ItemId = itemId;
            OrderId = orderId;
            Item = item;
            Order = order;
            Quantity = quantity;
            Price = price;
            Ordered = ordered;
            Details = details;
        }

        public OrderedItem(MyCartItem cartItem)
        {
            ItemId = cartItem.EldahanItemId;
            OrderId = cartItem.OrderId;
            Quantity = cartItem.Quantity;
            Price = (double) cartItem.EldahanItem.StaticPrice;
            Ordered = true;
            Details = cartItem.Details;
        }


    }
}