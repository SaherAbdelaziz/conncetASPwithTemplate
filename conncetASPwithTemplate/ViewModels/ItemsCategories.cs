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
       // public Modifys Modifys { get; set; }
        public List<WebPreset> WebPresets { get; set; }
        public List<WebMenuItem> WebMenuItems { get; set; }
        public int ItemsToShowCount { get; set; }


        public ItemsCategories(List<Item> items, List<WebPreset> webPresets, List<WebMenuItem> webMenuItems , int itemsToShowCount )
        {
            Items = items.ToList();
           // SubCategories = subCategories.ToList();
            WebPresets = webPresets.ToList();
            WebMenuItems = webMenuItems.ToList();
            ItemsToShowCount = itemsToShowCount;
            //Items = x.ToList();
            //SubCategories = y.ToList();
        }
    }

    
}