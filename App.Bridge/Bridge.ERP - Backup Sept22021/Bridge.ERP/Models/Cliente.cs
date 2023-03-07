using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
    }
}
