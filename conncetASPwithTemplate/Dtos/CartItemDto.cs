using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace conncetASPwithTemplate.Dtos
{
    public class CartItemDto
    {
        //public int Id { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public bool Removed { get; set; }

        public string Details { get; set; }

        public int ItemId { get; set; }

        public List<int> ItemsId { get; set; }

        
    }
}