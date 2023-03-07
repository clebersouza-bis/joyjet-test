using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models.Identity
{
    public partial class AspNetRole
    {
        public AspNetRole()
        {
            PropertiesTasks = new HashSet<PropertiesTask>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<PropertiesTask> PropertiesTasks { get; set; }
    }
}
