using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class Campaigns
    {
        public Campaigns()
        {
            CycleCampaignsTransactions = new HashSet<CycleCampaignsTransactions>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MarketType { get; set; }
        public string Pipeline { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CycleCampaignsTransactions> CycleCampaignsTransactions { get; set; }
    }
}
