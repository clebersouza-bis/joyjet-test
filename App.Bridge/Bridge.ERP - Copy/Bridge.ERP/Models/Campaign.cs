using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class Campaign
    {
        public Campaign()
        {
            CycleCampaignsTransactions = new HashSet<CycleCampaignsTransaction>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public int? ThirdPartyId { get; set; }
        public int? ThirdPartyCampaignId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string MarketType { get; set; }
        public string Pipeline { get; set; }
        public string Status { get; set; }
        public DateTime? RegisterDate { get; set; }
        public virtual ICollection<CycleCampaignsTransaction> CycleCampaignsTransactions { get; set; }
        //public virtual Customer Customer { get; set; }
    }
}
