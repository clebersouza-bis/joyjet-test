using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class LogAccess
    {
        public int Id { get; set; }
        public string SourceId { get; set; }
        public string ComputerId { get; set; }
        public string UserId { get; set; }
        public DateTime? AccessDate { get; set; }
    }
}
