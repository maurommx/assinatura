using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class NfEntradum
    {
        public NfEntradum()
        {
            NfEntradaItens = new HashSet<NfEntradaIten>();
        }

        public int Id { get; set; }
        public DateTime? Lancamento { get; set; }
        public int? Numero { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public int? IdCfop { get; set; }
        public string Cfop { get; set; }
        public string Especie { get; set; }
        public bool? Cancelada { get; set; }
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string Uf { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public double? BaseCalculoIcms { get; set; }
        public decimal? ValorIcms { get; set; }
        public double? CalculoIcmsSubstituicao { get; set; }
        public decimal? ValorIcmsSubstituicao { get; set; }
        public decimal? OutrasDespesas { get; set; }
        public decimal? ValorIpi { get; set; }
        public decimal? ValorTotalNota { get; set; }
        public bool? Mista { get; set; }
        public string Tipo { get; set; }
        public string Tipo1 { get; set; }
        public double? AliqIcms { get; set; }
        public double? RedIcms { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Cfop IdCfopNavigation { get; set; }
        public virtual ICollection<NfEntradaIten> NfEntradaItens { get; set; }
    }
}
