using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class Tag
    {
        public Tag()
        {
            PropertiesTags = new HashSet<PropertiesTag>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string TagName { get; set; }
        public string TagType { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string TagDescription { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<PropertiesTag> PropertiesTags { get; set; }
    }
}
