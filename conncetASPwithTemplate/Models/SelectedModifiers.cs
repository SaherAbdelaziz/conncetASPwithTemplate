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
        public int ItemId { get; set; }
        public int ItemModifierId { get; set; }
        public Item ItemModifier { get; set; }
        public SelectedModifiers()
        {

        }

        public SelectedModifiers( int itemId, string cartId , int itemModifierId)
        {
            ItemId = itemId;
            CartId = cartId;
            ItemModifierId = itemModifierId;
        }
    }
}