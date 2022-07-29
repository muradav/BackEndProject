﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllupProject.Models
{
    public class ShippingBanner
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; } = null;
        public string Desc { get; set; } = null;

    }
}