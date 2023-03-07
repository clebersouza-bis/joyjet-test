using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class Contacts
    {
        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string MainState { get; set; }
        public string MainCity { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public double? LocationsCount { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string ContactType { get; set; }
        public string SourceName { get; set; }
        public string CreatedType { get; set; }
        public string CriticalStatus { get; set; }
        public bool? IsHotContact { get; set; }
        public string Vipcontact { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public virtual Customers Tenant { get; set; }

    }
}
