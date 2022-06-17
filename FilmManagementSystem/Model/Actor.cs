using System;
using System.Collections.Generic;

#nullable disable

namespace FilmManagementSystem.Models
{
    public partial class Actor
    {
        public Actor()
        {
            Films = new HashSet<Film>();
        }

        public string ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}