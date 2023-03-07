﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class ContactsLocations
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int LocationId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        public virtual Locations Location { get; set; }
        public virtual Customers Tenant { get; set; }
    }
}
