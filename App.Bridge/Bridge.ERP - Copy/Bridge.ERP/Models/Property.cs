using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class Property
    {
        public Property()
        {
            LeadsFollowUpProperties = new HashSet<LeadsFollowUp>();
            PropertiesLists = new HashSet<PropertiesList>();
            PropertiesTags = new HashSet<PropertiesTag>();
            PropertiesTasks = new HashSet<PropertiesTask>();
            Phones = new HashSet<Phone>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyState { get; set; }
        public string PropertyZip { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double? ListCount { get; set; }
        public double? MailerCount { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string OptOut { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string PropertyCounty { get; set; }
        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingZip { get; set; }
        public string MailingCounty { get; set; }
        public string IsVacant { get; set; }
        public string IsMailingVacant { get; set; }
        public string ApnNumber { get; set; }
        public string PropertyTypeDetail { get; set; }
        public string OwnerOccupied { get; set; }
        public double? BedroomCount { get; set; }
        public double? BathroomCount { get; set; }
        public double? TotalBuildingAreaSquareFeet { get; set; }
        public double? LotSizeSquareFeet { get; set; }
        public double? YearBuilt { get; set; }
        public double? TotalAssessedValue { get; set; }
        public string ZoningCode { get; set; }
        public string LastStaleDate { get; set; }
        public string LastSalePrice { get; set; }
        public string TotalOpenLienBalance { get; set; }
        public double? EquityCurrentEstimatedBalance { get; set; }
        public double? EstimatedValue { get; set; }
        public double? LtvCurrentEstimatedCombined { get; set; }
        public string MlsStatus { get; set; }
        public string Owner2FirstName { get; set; }
        public string Owner2LastName { get; set; }
        public string PropertyType { get; set; }
        public string PrimaryListSource { get; set; }
        public string PrimaryListType { get; set; }
        public string CriticalStatus { get; set; }
        public string HotLead { get; set; }
        public string MatchCrm { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual LeadsFollowUp LeadsFollowUpIdNavigation { get; set; }
        public virtual ICollection<LeadsFollowUp> LeadsFollowUpProperties { get; set; }
        public virtual ICollection<PropertiesList> PropertiesLists { get; set; }
        public virtual ICollection<PropertiesTag> PropertiesTags { get; set; }
        public virtual ICollection<PropertiesTask> PropertiesTasks { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
}
