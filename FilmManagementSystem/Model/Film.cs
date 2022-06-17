using System;
using System.Collections.Generic;

#nullable disable

namespace FilmManagementSystem.Models
{
    public partial class Film
    {
        public int FilmId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int? ReleaseYear { get; set; }
        public string LanguageId { get; set; }
        public int? RentalDurationDays { get; set; }
        public int? LengthMins { get; set; }
        public int? ReplacementCostCrores { get; set; }
        public decimal? Rating { get; set; }
        public string SpecialFeatures { get; set; }
        public string ActorId { get; set; }
        public string CategoryId { get; set; }

        public virtual Actor Actor { get; set; }
        public virtual Category Category { get; set; }
        public virtual Language Language { get; set; }
    }
}
