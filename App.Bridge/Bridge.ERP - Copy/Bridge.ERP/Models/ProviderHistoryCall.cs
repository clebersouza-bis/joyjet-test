using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class ProviderHistoryCall
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int? PropertyId { get; set; }
        public int ProviderId { get; set; }
        public int? ContactId { get; set; }
        public string CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string OutboundPhoneId { get; set; }
        public string DestinationPhone { get; set; }
        public string CallId { get; set; }
        public DateTime CallStartDate { get; set; }
        public int? CallDuration { get; set; }
        public string CallDisposition { get; set; }
        public string SystemDisposition { get; set; }
        public string CallRecordPath { get; set; }
        public string AgentName { get; set; }
        public string DirectionType { get; set; }
        public string ContactDisposition { get; set; }

        public virtual ThirdPartProvider Provider { get; set; }
        public virtual Customer Tenant { get; set; }

    }
}
