using System;
using System.Collections.Generic;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class ProfileSkill
    {
        public int Id { get; set; }
        public int? ProfileId { get; set; }
        public string SkillName { get; set; }
        public string SkillLevel { get; set; }
        public string Description { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
