using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class LeadsFollowUp
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string LeadStatus { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string Notes { get; set; }
        public int TenantId { get; set; }
        public string MarketType { get; set; }

        public virtual Property IdNavigation { get; set; }
        public virtual Property Property { get; set; }
    }
}
