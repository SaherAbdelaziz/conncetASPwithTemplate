using conncetASPwithTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace conncetASPwithTemplate.Dtos
{
    public class ItemsAndGroupCount
    {
        public List<EldahanItems> Items { get; set; }
        public int ModifiersGroupCount { get; set; }

        public ItemsAndGroupCount()
        {

        }

        public ItemsAndGroupCount(List<EldahanItems> items , int count)
        {
            Items = items.ToList(); 
            ModifiersGroupCount = count;
        }
    }
}