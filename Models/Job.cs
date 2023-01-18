using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GregSharp.Models
{
    public class Job
    {
        public int? Id { get; set; }
        public string Company { get; set; }
        public string jobTitle { get; set; }
        public int? Salary { get; set; }
        public int? Hours { get; set; }
        public string Prerequisites { get; set; }
        public string imgUrl { get; set; }
        public string Description { get; set; }
    }
}