﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace conncetASPwithTemplate.Models
{
    public class MyCartItem
    {
        public int Id { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public bool Removed { get; set; }
        public string Details { get; set; }
        public bool HasModifiers { get; set; }
        public bool Ordered { get; set; }
        public int OrderId { get; set; }

        public int EldahanItemId { get; set; }

        public EldahanItems EldahanItem { get; set; }

    }
}