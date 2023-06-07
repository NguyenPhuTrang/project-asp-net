using System;
using System.Collections.Generic;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
