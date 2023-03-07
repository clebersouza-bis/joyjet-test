using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class RecycledCampaignsLists
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int? CampaignId { get; set; }
        public int? PropertyId { get; set; }
        public int? PhoneId { get; set; }
        public int? CycleNumber { get; set; }
        public string ContactSucess { get; set; }
        public string ListName { get; set; }
        public string VoicePhone { get; set; }
        public string Disposition { get; set; }
        public string ReasonCode { get; set; }
        public string DispositionForRecyle { get; set; }
        public string Recycle { get; set; }
        public string User { get; set; }
        public double? CallLength { get; set; }
        public double? WrapUpTime { get; set; }
        public double? IsHit { get; set; }
        public string DialNumberType { get; set; }
        public string CallType { get; set; }
        public string SecondaryVoicePhone { get; set; }
        public string Homephone { get; set; }
        public string Cellphone { get; set; }
        public string Faxphone { get; set; }
        public string Note { get; set; }
        public string OutboundCallerId { get; set; }
        public string RecordingFileName { get; set; }
        public string Status { get; set; }
        public string MarketType { get; set; }
    }
}
