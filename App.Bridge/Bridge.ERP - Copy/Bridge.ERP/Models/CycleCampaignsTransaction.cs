using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class CycleCampaignsTransaction
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public int CycleNumber { get; set; }
        public string CycleStatus { get; set; }
        public int TenantId { get; set; }
        public string MarketType { get; set; }

        public virtual Campaign Campaign { get; set; }
        public virtual Customer Tenant { get; set; }
    }
}
