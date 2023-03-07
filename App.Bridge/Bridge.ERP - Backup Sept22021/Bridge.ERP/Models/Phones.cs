using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public class Phones
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int? PropertyId { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public int? Score { get; set; }
        public string Status { get; set; }
        public string SkipTraceSource { get; set; }
        public string ContactType { get; set; }
       // public Customers Customers { get; set; }
        public Properties Property { get;set;  }
        //public Contacts Contacts { get; set; }
    }
}
