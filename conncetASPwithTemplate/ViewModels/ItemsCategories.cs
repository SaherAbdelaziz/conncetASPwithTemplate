using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using conncetASPwithTemplate.Models;

namespace conncetASPwithTemplate.ViewModels
{
    public class ItemsCategories
    {
        public List<Item> Items { get; set; }
        public Modifys Modifys { get; set; }
        public List<SubCategory> SubCategories { get; set; }
        public int ItemsToShowCount { get; set; }


        public ItemsCategories(List<Item> items, List<SubCategory> subCategories, int itemsToShowCount)
        {
            Items = items.ToList();
            SubCategories = subCategories.ToList();
            ItemsToShowCount = itemsToShowCount;
            //Items = x.ToList();
            //SubCategories = y.ToList();
        }
    }

    
}