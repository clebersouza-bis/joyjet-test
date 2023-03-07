using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public DateTime Datacadastro { get; set; }
    }
}
