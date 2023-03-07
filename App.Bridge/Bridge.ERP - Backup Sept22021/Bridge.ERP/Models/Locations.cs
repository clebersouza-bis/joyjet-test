using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class Locations
    {
        public Locations()
        {
            ContactsLocations = new HashSet<ContactsLocations>();
        }

        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Neighborhood { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<ContactsLocations> ContactsLocations { get; set; }
    }
}
