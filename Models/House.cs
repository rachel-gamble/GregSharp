using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GregSharp.Models
{
    public class House
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int? Price { get; set; }
        public string Address { get; set; }

        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public int? Levels { get; set; }
        public int? Year { get; set; }
        public string imgUrl { get; set; }
        public string Description { get; set; }
    }
}