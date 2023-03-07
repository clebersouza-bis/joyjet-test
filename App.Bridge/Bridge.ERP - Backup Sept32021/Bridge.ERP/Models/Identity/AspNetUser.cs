﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models.Identity
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            PropertiesTaskUserAssigneds = new HashSet<PropertiesTask>();
            PropertiesTaskUsers = new HashSet<PropertiesTask>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<PropertiesTask> PropertiesTaskUserAssigneds { get; set; }
        public virtual ICollection<PropertiesTask> PropertiesTaskUsers { get; set; }
    }
}