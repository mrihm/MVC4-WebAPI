﻿using System;

namespace Data.Model
{
    public class Status
    {
        public virtual long StatusId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Ordinal { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
