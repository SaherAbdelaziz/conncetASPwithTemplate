using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace conncetASPwithTemplate.Models
{
    public class SelectedModifiers
    {
        public int Id { get; set; }
        public string CartId { get; set; }
        public int EldahanItemsId { get; set; }
        public int ItemModifierId { get; set; }
        public EldahanItems ItemModifier { get; set; }
        public SelectedModifiers()
        {

        }

        public SelectedModifiers( int itemId, string cartId , int itemModifierId)
        {
            EldahanItemsId = itemId;
            CartId = cartId;
            ItemModifierId = itemModifierId;
        }
    }
}