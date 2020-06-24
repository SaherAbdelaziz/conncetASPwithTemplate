using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using conncetASPwithTemplate.Models;

namespace conncetASPwithTemplate.ViewModels
{
    public class ItemsCategories
    {
        public List<EldahanItems2> Items { get; set; }
       // public Modifys Modifys { get; set; }
        public List<EldahanPreset> Presets { get; set; }
        public List<WebMenuItem> MenuItems { get; set; }
        public int ItemsToShowCount { get; set; }


        public ItemsCategories(List<EldahanItems2> items, List<EldahanPreset> webPresets, List<WebMenuItem> webMenuItems , int itemsToShowCount )
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