using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class Tags
    {
        public Tags()
        {
            PropertiesTags = new HashSet<PropertiesTags>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string TagName { get; set; }
        public string TagType { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string TagDescription { get; set; }

        public virtual ICollection<PropertiesTags> PropertiesTags { get; set; }
    }
}
