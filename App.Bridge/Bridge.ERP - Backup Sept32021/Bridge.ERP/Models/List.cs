using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class List
    {
        public List()
        {
            PropertiesLists = new HashSet<PropertiesList>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string ListName { get; set; }
        public string ListType { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string ListDescription { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<PropertiesList> PropertiesLists { get; set; }
    }
}
