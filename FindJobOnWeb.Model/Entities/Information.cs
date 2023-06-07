using System;
using System.Collections.Generic;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class Information
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contens { get; set; }
        public string Author { get; set; }
        public DateTime? DatePost { get; set; }
        public string Image { get; set; }
    }
}
