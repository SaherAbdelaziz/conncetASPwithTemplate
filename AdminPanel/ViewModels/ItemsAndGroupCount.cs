using System.Collections.Generic;
using System.Linq;
using AdminPanel.Models;

namespace AdminPanel.ViewModels
{
    public class ItemsAndGroupCount
    {
        public List<Item> Items { get; set; }
        public int ModifiersGroupCount { get; set; }

        public ItemsAndGroupCount()
        {

        }

        public ItemsAndGroupCount(List<Item> items, int count)
        {
            Items = items.ToList();
            ModifiersGroupCount = count;
        }
    }
}