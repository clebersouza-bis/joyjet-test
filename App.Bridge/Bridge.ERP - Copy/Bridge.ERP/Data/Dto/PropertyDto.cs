using Bridge.ERP.Models;
using System.Collections.Generic;

namespace Bridge.ERP.Data.Dto
{
    public class PropertyDto
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyState { get; set; }
        public string PropertyZip { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
}
