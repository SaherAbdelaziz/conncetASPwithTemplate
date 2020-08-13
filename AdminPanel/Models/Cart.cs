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

        private List<CartItem> _cartItems;


        public Cart()
        {
            _cartItems = new List<CartItem>();
        }

        public Cart(List<CartItem> cartItem)
        {

            _cartItems = cartItem;
        }

        public Cart(string applicationUserId)
        {
            _cartItems = new List<CartItem>();
            ApplicationUserId = applicationUserId;
        }


        public void GetTotalPrice()
        {
            TotalPrice = 0;

            foreach (var myCartItem in _cartItems)
            {
                TotalPrice = (double)(myCartItem.Quantity * myCartItem.Item.StaticPrice);
            }
        }

        public void AddCartItem(CartItem cartItem)
        {
            _cartItems.Add(cartItem);
        }

        public void DeleteCart()
        {
            _cartItems.Clear();
        }
    }
}