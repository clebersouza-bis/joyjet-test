using System;
using System.Collections.Generic;

#nullable disable

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
