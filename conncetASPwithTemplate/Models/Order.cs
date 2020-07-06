using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace conncetASPwithTemplate.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime? DateCreated { get; set; }
        public double Price { get; set; }
        public double Delivery { get; set; }
        public double TotalPrice { get; set; }
        public OutLet OutLet { get; set; }
        public int OutLetId { get; set; }
        public HD_Areas HdAreas { get; set; }
        public int HdAreasId { get; set; }
        public HD_Areas_Services Services { get; set; }
        public int ServicesId { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int DeliveryTimeIndex { get; set; }
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