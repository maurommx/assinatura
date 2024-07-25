using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class NfEntradaIten
    {
        public int Id { get; set; }
        public int? IdNfEntrada { get; set; }
        public int? IdCfop { get; set; }
        public double? Codigo { get; set; }
        public string Cst { get; set; }
        public double? Qtda { get; set; }
        public decimal? Valor { get; set; }
        public double? AliqIcms { get; set; }
        public double? RedIcms { get; set; }
        public double? ValorIpi { get; set; }
        public double? Ipi { get; set; }
        public string Produto { get; set; }
        public string Unidade { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Cfop IdCfopNavigation { get; set; }
        public virtual NfEntradum IdNfEntradaNavigation { get; set; }
    }
}
