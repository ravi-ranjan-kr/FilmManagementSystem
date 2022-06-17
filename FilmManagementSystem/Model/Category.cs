using System;
using System.Collections.Generic;

#nullable disable

namespace FilmManagementSystem.Models
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
