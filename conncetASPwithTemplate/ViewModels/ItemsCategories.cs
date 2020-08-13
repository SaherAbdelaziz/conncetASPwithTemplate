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
        public List<Web_Preset> Presets { get; set; }
        public List<Web_Menu_Item> MenuItems { get; set; }
        public int ItemsToShowCount { get; set; }


        public ItemsCategories(List<Item> items, List<Web_Preset> webPresets, List<Web_Menu_Item> webMenuItems , int itemsToShowCount )
        {
            Items = items.ToList();
            // SubCategories = subCategories.ToList();
            Presets = webPresets.ToList();
            MenuItems = webMenuItems.ToList();
            ItemsToShowCount = itemsToShowCount;
            //Items = x.ToList();
            //SubCategories = y.ToList();
        }
    }

    
}