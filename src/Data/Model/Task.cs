﻿using System;
using System.Collections.Generic;

namespace Data.Model
{
    public class Task
    {
        public virtual long TaskId { get; set; }
        public virtual string Subject { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? DueDate { get; set; }
        public virtual DateTime? DateCompleted { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Status Status { get; set; }
        public virtual byte[] Timestamp { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        private readonly IList<User> _users = new List<User>();
        private readonly IList<Category> _categories = new List<Category>();

        public virtual IList<User> Users 
        {
            get { return _users; }
        }

        public virtual IList<Category> Categories
        {
            get { return _categories; }
        }
    }
}
