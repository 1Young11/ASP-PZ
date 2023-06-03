using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Models
{
    public class Flower
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int IdCategory { get; set; }
        public string img { get; set; }
    }
}
