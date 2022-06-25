using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.DataOperation_fa.Models
{
    public partial class Language
    {
        public Language()
        {
            Films = new HashSet<Film>();
        }

        public string LanguageId { get; set; }
        public string LanguageName { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}
