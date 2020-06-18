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

        public SelectedModifiers()
        {

        }

        public SelectedModifiers(string cartId, int itemId, int itemModifierId)
        {
            CartId = cartId;
            ItemId = itemId;
            ItemModifierId = itemModifierId;
        }
    }
}