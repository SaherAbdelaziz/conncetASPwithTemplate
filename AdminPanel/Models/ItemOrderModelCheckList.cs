using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPanel.Models
{
    public class ItemOrderModelCheckList
    {
        public int OrderId { get; set; }
        public IList<string> SelectedItems { get; set; }
        public IList<SelectListItem> AvailableItem { get; set; }

        public ItemOrderModelCheckList()
        {
            SelectedItems = new List<string>();
            AvailableItem = new List<SelectListItem>();
        }

        public ItemOrderModelCheckList(int orderId, IList<string> selectedItems, IList<SelectListItem> availableItem)
        {
            OrderId = orderId;
            SelectedItems = selectedItems;
            AvailableItem = availableItem;
        }

        public ItemOrderModelCheckList(int orderId, IList<SelectListItem> availableItem)
        {
            OrderId = orderId;
            AvailableItem = availableItem;
        }
    }
}