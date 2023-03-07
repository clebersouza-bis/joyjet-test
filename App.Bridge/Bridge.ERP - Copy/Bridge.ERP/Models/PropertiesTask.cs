using Bridge.ERP.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class PropertiesTask
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int PropertyId { get; set; }
        public string TaskTitle { get; set; }
        public string AssignedType { get; set; }
        public string UserId { get; set; }
        public string UserAssignedId { get; set; }
        public string DepartmentId { get; set; }
        public bool HasDeadline { get; set; }
        public DateTime? DueDate { get; set; }
        public bool RepeatTask { get; set; }
        public string RepeatFrequency { get; set; }
        public DateTime? RepeatFinalDate { get; set; }
        public bool DueStatus { get; set; }
        public string Priority { get; set; }
        public string TaskStatus { get; set; }
        public string Notes { get; set; }
        public bool HasAttach { get; set; }
        public string FilePath { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual AspNetRole Department { get; set; }
        public virtual Property Property { get; set; }
        public virtual Customer Tenant { get; set; }
        [NotMapped]
        public virtual AspNetUser User { get; set; }
        [NotMapped]
        public virtual AspNetUser UserAssigned { get; set; }
    }
}
