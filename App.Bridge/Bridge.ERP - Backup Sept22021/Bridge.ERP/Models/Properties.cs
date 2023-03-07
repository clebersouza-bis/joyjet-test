using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public class Properties
    {
        //public Properties()
        //{
        //    LeadsFollowUpsProperty = new HashSet<LeadsFollowUps>();
        //    PropertiesLists = new HashSet<PropertiesLists>();
        //    PropertiesTags = new HashSet<PropertiesTags>();
        //    //Phone = new HashSet<Phones>();
        //}

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

        public virtual LeadsFollowUps LeadsFollowUpsIdNavigation { get; set; }
        public virtual ICollection<LeadsFollowUps> LeadsFollowUpsProperty { get; set; }
        public virtual ICollection<PropertiesLists> PropertiesLists { get; set; }
        public virtual ICollection<PropertiesTags> PropertiesTags { get; set; }
        public IEnumerable<Phones> Phone { get; set; }

    }
}
