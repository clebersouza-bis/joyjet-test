using System;
using System.Collections.Generic;

#nullable disable

namespace Bridge.ERP.Models
{
    public partial class Lancamento
    {
        public int IdLancamento { get; set; }
        public int IdCorretora { get; set; }
        public int IdSeguradora { get; set; }
        public string Apolice { get; set; }
        public string Ordem { get; set; }
        public string Endosso { get; set; }
        public string Ramo { get; set; }
        public DateTime? Vigencia { get; set; }
        public string Prc { get; set; }
        public DateTime Vencto { get; set; }
        public decimal Premio { get; set; }
        public double Taxa { get; set; }
        public decimal ValorCms { get; set; }
        public string Segurado { get; set; }
        public DateTime DataLancto { get; set; }
        public string Status { get; set; }
        public string StatusContabil { get; set; }
        public DateTime MesReferencia { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
