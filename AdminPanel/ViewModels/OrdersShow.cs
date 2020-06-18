using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminPanel.Models;

namespace AdminPanel.ViewModels
{
    public class OrdersShow
    {
        public List<Order> Orders { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}