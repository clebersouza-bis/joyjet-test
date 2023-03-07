using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Models
{
    public partial class Category
    {
        public Category()
        {
            InverseParent = new HashSet<Category>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }

        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> InverseParent { get; set; }
    }
}
