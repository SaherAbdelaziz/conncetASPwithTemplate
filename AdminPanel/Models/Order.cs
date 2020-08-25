using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class Order
    {
        public int Id { get; set; }


        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public string AdminId { get; set; }
        public ApplicationUser Admin { get; set; }


        public long CheckId { get; set; }
        public Check Check { get; set; }
        
        public DateTime? DateCreated { get; set; }
        public double Price { get; set; }
        public double Delivery { get; set; }
        public double TotalPrice { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int DeliveryTimeIndex { get; set; }
        public string DeliveryTypeIndex { get; set; }

        public string Details { get; set; }

        public int OrderState { get; set; }
        public int OrderPrepare { get; set; }

        public Order()
        {
            
        }




        public Order(int id, string userId, ApplicationUser user, string adminId, ApplicationUser admin, long checkId, Check check, DateTime? dateCreated, double price, double delivery, double totalPrice, int cartId, Cart cart, int deliveryTimeIndex, string deliveryTypeIndex, string details, int orderState, int orderPrepare)
        {
            Id = id;
            UserId = userId;
            User = user;
            AdminId = adminId;
            Admin = admin;
            CheckId = checkId;
            Check = check;
            DateCreated = dateCreated;
            Price = price;
            Delivery = delivery;
            TotalPrice = totalPrice;
            CartId = cartId;
            Cart = cart;
            DeliveryTimeIndex = deliveryTimeIndex;
            DeliveryTypeIndex = deliveryTypeIndex;
            Details = details;
            OrderState = orderState;
            OrderPrepare = orderPrepare;
        }


        public void Update(double? price)
        {
            Price = (double) price;
            TotalPrice = (double) (price + Delivery);
        }


    }
}