using System;
using System.Collections.Generic;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class Experience
    {
        public int Id { get; set; }
        public int? ProfileId { get; set; }
        public string CurrentJob { get; set; }
        public string YearOfExperience { get; set; }
        public string NameCompany { get; set; }
        public string Description { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
