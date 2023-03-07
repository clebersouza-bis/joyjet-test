using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class VehiclesOnMarket
    {
        public int Id { get; set; }
        public long? SourceId { get; set; }
        public string UrlVehicle { get; set; }
        public string Photos { get; set; }
        public DateTime? PublishDate { get; set; }
        public string VehicleFull { get; set; }
        public string Vin { get; set; }
        public decimal? Price { get; set; }
        public string Location { get; set; }
        public string RadiusDistance { get; set; }
        public string SellerType { get; set; }
        public string Seller { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ExtractTime { get; set; }
        public decimal? Odometer { get; set; }
        public string Titlestatus { get; set; }
        public string VehicleFullDecoded { get; set; }
        public string VehicleYear { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleSeries { get; set; }
        public string Description { get; set; }
        public string Transmition { get; set; }
        public string SaleStatus { get; set; }
        public string FollowUp { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string FollowUpUser { get; set; }
        public string SourceName { get; set; }
        public string AvailableStatus { get; set; }
        public string SourceType { get; set; }
        public string Notes { get; set; }
    }
}
