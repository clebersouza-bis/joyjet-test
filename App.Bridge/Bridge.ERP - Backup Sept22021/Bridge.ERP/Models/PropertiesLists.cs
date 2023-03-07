using Bridge.ERP.Models;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class PropertiesLists
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int ListId { get; set; }
        public int PropertyId { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }

        public virtual Lists List { get; set; }
        public virtual Properties Property { get; set; }
    }
}
