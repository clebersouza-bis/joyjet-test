using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class PropertiesTag
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int TagId { get; set; }
        public int PropertyId { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Property Property { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
