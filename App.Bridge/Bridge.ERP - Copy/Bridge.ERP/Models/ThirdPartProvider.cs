using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class ThirdPartProvider
    {
        public ThirdPartProvider()
        {
            ProviderHistoryCalls = new HashSet<ProviderHistoryCall>();
        }

        public int Id { get; set; }
        public string ProviderName { get; set; }
        public string ProviderType { get; set; }
        public DateTime? RegisterDate { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<ProviderHistoryCall> ProviderHistoryCalls { get; set; }
    }
}
