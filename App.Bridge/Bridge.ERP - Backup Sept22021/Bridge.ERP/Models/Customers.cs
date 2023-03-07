using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Contacts = new HashSet<Contacts>();
            ContactsLocations = new HashSet<ContactsLocations>();
            CycleCampaignsTransactions = new HashSet<CycleCampaignsTransactions>();
            ImportHistory = new HashSet<ImportHistory>();
            //Phone = new HashSet<Phones>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IpAddress { get; set; }
        public string Plan { get; set; }
        public int PaymentPeriod { get; set; }
        public int PaymentOption { get; set; }
        public int PaymentCheck { get; set; }

        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<ContactsLocations> ContactsLocations { get; set; }
        public virtual ICollection<CycleCampaignsTransactions> CycleCampaignsTransactions { get; set; }
        public virtual ICollection<ImportHistory> ImportHistory { get; set; }
        //public virtual IEnumerable<Phones> Phone { get; set; }

    }
}
