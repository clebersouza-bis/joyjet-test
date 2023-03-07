using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP
{
    public partial class Seguradora
    {
        public int IdSeguradora { get; set; }
        public string NomeSeguradora { get; set; }
        public string StatusSeguradora { get; set; }
        public string Cnpj { get; set; }
        public string Ramo { get; set; }
    }
}
