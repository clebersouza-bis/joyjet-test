using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Contacts = new HashSet<Contact>();
            ContactsLocations = new HashSet<ContactsLocation>();
            CycleCampaignsTransactions = new HashSet<CycleCampaignsTransaction>();
            ImportHistories = new HashSet<ImportHistory>();
            PropertiesTasks = new HashSet<PropertiesTask>();
            ProviderHistoryCall = new HashSet<ProviderHistoryCall>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public string IpAddress { get; set; }
        public string Plan { get; set; }
        public int PaymentPeriod { get; set; }
        public int PaymentOption { get; set; }
        public int PaymentCheck { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<ContactsLocation> ContactsLocations { get; set; }
        public virtual ICollection<CycleCampaignsTransaction> CycleCampaignsTransactions { get; set; }
        public virtual ICollection<ImportHistory> ImportHistories { get; set; }
        public virtual ICollection<PropertiesTask> PropertiesTasks { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<ProviderHistoryCall> ProviderHistoryCall { get; set; }

    }
}
