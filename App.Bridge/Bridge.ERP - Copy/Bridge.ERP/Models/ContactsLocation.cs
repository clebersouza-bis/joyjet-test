using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class ContactsLocation
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int LocationId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Location Location { get; set; }
        public virtual Customer Tenant { get; set; }
    }
}
