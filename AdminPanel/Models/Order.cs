﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DateCreated { get; set; }
        public double Price { get; set; }
        public double Delivery { get; set; }
        public double TotalPrice { get; set; }
        public string CartId { get; set; }

        public string Details { get; set; }
        //public List<int> CartItemsId { get; set; }
        //public List<CartItem> CartItems { get; set; }

        //public Order()
        //{
        //    CartItems = new List<CartItem>();
        //}

        //public Order(int id, string customerName, string cartId, List<int> cartItemsId, List<CartItem> cartItems)
        //{
        //    Id = id;
        //    CustomerName = customerName;
        //    CartId = cartId;
        //    CartItemsId = cartItemsId;
        //    CartItems = cartItems;
        //}


    }
}