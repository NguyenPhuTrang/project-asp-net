using System;
using System.Collections.Generic;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public string Contens { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
    }
}
