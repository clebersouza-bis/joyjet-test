using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class TransactionsCampaign
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int? CampaignId { get; set; }
        public int? PropertyId { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string Status { get; set; }
        public string MarketType { get; set; }
    }
}
