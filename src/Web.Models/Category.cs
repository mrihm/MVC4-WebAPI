using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Link> Links { get; set; }
    }
}
