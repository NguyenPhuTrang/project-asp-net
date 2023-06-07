using System;
using System.Collections.Generic;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class JobPost
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public int? SkillId { get; set; }
        public string JobTypeName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int? Salary { get; set; }
        public string Skill { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }

        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
    }
}
