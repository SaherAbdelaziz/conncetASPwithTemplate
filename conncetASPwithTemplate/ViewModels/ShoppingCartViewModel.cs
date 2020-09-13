using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using conncetASPwithTemplate.Models;

namespace conncetASPwithTemplate.ViewModels
{
    public class ShoppingCartViewModel
    {
        public double? DisValue { get; set; }
        public string DisName { get; set; }

        public List<CartItem> Items { get; set; }

        public ShoppingCartViewModel(double? disValue, string disName, List<CartItem> items)
        {
            DisValue = disValue;
            DisName = disName;
            Items = items;
        }
    }
}