﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public List<Flower> Flowers { get; set; }
        public int minPrice { get; set; }
        public int maxPrice { get; set; }
        public string img { get; set; }
    }
}
