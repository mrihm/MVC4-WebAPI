﻿using System;

namespace Data.Model
{
    public class Category
    {
        public virtual long CategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
