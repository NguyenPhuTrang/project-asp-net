using System;
using System.Collections.Generic;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class Profile
    {
        public Profile()
        {
            Educations = new HashSet<Education>();
            Experiences = new HashSet<Experience>();
            ProfileSkills = new HashSet<ProfileSkill>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public string FullName { get; set; }
        public string CurrentSalary { get; set; }
        public string Currency { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<ProfileSkill> ProfileSkills { get; set; }
    }
}
