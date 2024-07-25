using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class NfCanceladasIten
    {
        public int Id { get; set; }
        public int? IdNota { get; set; }
        public int? IdProduto { get; set; }
        public int? IdProdutoNovo { get; set; }
        public int? IdInsumo { get; set; }
        public int? IdUnidade { get; set; }
        public double? Qtda { get; set; }
        public double? Ipi { get; set; }
        public decimal? Valor { get; set; }
        public double? QtdVolume { get; set; }
        public string Cst { get; set; }
        public double? BaseCalcIcms { get; set; }
        public double? BaseCalcIpi { get; set; }
        public string Modalidade { get; set; }
        public double? ValorIcms { get; set; }
        public double? ValorIpi { get; set; }
        public double? AliqIcms { get; set; }
        public double? RedIcms { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Insumo IdInsumoNavigation { get; set; }
        public virtual NfCancelada IdNotaNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual Unidade IdUnidadeNavigation { get; set; }
    }
}
