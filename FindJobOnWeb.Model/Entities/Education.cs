using System;
using System.Collections.Generic;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class Education
    {
        public int Id { get; set; }
        public int? ProfileId { get; set; }
        public string CertificateDegreeName { get; set; }
        public string Majoring { get; set; }
        public string Jpa { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
