using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class Lists
    {
        public Lists()
        {
            PropertiesLists = new HashSet<PropertiesLists>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string ListName { get; set; }
        public string ListType { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string ListDescription { get; set; }

        public virtual ICollection<PropertiesLists> PropertiesLists { get; set; }
    }
}
