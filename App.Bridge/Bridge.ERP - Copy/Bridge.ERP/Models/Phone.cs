using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int PropertyId { get; set; }
        public string PhoneNumber { get; set; }
        public string Type { get; set; }
        public int? Score { get; set; }
        public string Status { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public DateTime? SkipTraceDate { get; set; }
        public string SkipTraceSource { get; set; }
        public string ContactType { get; set; }
        public Property Property { get; set; }
        public Customer Customers { get; set; }



    }
}
