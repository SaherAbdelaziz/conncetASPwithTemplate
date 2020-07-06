using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string SessionId { get; set; }
        public double TotalPrice { get; set; }

        private List<MyCartItem> _cartItems;


        public Cart()
        {
            _cartItems = new List<MyCartItem>();
        }

        public Cart(List<MyCartItem> cartItem)
        {

            _cartItems = cartItem;
        }

        public Cart(string applicationUserId)
        {
            _cartItems = new List<MyCartItem>();
            ApplicationUserId = applicationUserId;
        }


        public void GetTotalPrice()
        {
            TotalPrice = 0;

            foreach (var myCartItem in _cartItems)
            {
                TotalPrice = (double)(myCartItem.Quantity * myCartItem.EldahanItem.StaticPrice);
            }
        }

        public void AddCartItem(MyCartItem cartItem)
        {
            _cartItems.Add(cartItem);
        }

        public void DeleteCart()
        {
            _cartItems.Clear();
        }
    }
}