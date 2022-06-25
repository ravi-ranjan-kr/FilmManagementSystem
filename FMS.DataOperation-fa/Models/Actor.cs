using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.DataOperation_fa.Models
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
