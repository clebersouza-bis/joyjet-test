using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class Location
    {
        public Location()
        {
            ContactsLocations = new HashSet<ContactsLocation>();
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

        public virtual ICollection<ContactsLocation> ContactsLocations { get; set; }
    }
}
