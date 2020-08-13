using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminPanel.Models;

namespace AdminPanel.ViewModels
{
    public class OrdersViewModel
    {
        public List<Order> Orders { get; set; }
        public List<CartItem> MyCartItems { get; set; }
        public List<ChecksItem> ChecksItems { get; set; }
    }
}