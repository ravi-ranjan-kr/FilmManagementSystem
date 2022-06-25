﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.DataOperation_fa.Models
{
    public partial class Category
    {
        public Category()
        {
            Films = new HashSet<Film>();
        }

        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}
