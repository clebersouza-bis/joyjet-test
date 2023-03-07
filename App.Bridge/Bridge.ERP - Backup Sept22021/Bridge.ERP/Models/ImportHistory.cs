using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class ImportHistory
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string FileName { get; set; }
        public string ListName { get; set; }
        public int RecordsCount { get; set; }
        public string ListStatus { get; set; }
        public int ImportedCount { get; set; }
        public int NotImportedCount { get; set; }
        public int UpdatedCount { get; set; }
        public string FileLink { get; set; }
        public string FailReason { get; set; }

        public virtual Customers Tenant { get; set; }
    }
}
