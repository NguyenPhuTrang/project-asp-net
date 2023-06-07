using System;
using System.Collections.Generic;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class User
    {
        public User()
        {
            JobPosts = new HashSet<JobPost>();
            Profiles = new HashSet<Profile>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public virtual ICollection<JobPost> JobPosts { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
