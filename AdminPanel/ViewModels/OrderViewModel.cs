using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminPanel.Models;

namespace AdminPanel.ViewModels
{
    public class OrderViewModel
    {
        
        public Order Order { get; set; }
        public List<ChecksItem> ChecksItems { get; set; }


        public OrderViewModel()
        {
            
        }

        public OrderViewModel(Order order, List<ChecksItem> checksItems)
        {
            Order = order;
            ChecksItems = checksItems;
        }

    }
}