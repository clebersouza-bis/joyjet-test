using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class Category
    {
        public Category()
        {
            InverseParent = new HashSet<Category>();
        }

        public uint Id { get; set; }
        public string Title { get; set; }
        public uint? ParentId { get; set; }

        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> InverseParent { get; set; }
    }
}
