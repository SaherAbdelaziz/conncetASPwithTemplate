using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminPanel.Models;

namespace AdminPanel.ViewModels
{
    public class EditOrderItemsViewModel
    {
        public OrderViewModel OrderViewModel { get; set; }
        public List<Item> Items { get; set; }

        public EditOrderItemsViewModel()
        {
            
        }

        public EditOrderItemsViewModel(OrderViewModel orderViewModel, List<Item> items)
        {
            OrderViewModel = orderViewModel;
            Items = items;
        }
    }
}