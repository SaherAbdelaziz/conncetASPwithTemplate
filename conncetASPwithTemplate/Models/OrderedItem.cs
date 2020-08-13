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

        public Item Item { get; set; }
        public Order Order { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool Ordered { get; set; }
        public string Details { get; set; }


        public OrderedItem()
        {
            
        }

        public OrderedItem(int itemId, int orderId, Item item, Order order, int quantity, int price, bool ordered , string details)
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

        public OrderedItem(CartItem cartItem)
        {
            ItemId = cartItem.ItemId;
            OrderId = cartItem.OrderId;
            Quantity = cartItem.Quantity;
            Price = (double) cartItem.Item.StaticPrice;
            Ordered = true;
            Details = cartItem.Details;
        }


    }
}