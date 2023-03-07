using System;
using System.Collections.Generic;

#nullable disable

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
        public DateTime RegisterDate { get; set; }
        public string FileLink { get; set; }
        public string FailReason { get; set; }

        public virtual Customer Tenant { get; set; }
    }
}
