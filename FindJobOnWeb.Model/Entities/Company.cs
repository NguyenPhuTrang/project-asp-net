using System;
using System.Collections.Generic;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class Company
    {
        public Company()
        {
            JobPosts = new HashSet<JobPost>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string BusinessStreamName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<JobPost> JobPosts { get; set; }
    }
}
