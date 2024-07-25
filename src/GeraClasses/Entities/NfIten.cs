using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class NfIten
    {
        public int Id { get; set; }
        public int? IdNota { get; set; }
        public int? IdProdutoNovo { get; set; }
        public int? IdProduto { get; set; }
        public int? IdInsumo { get; set; }
        public int? IdUnidade { get; set; }
        public double? Qtda { get; set; }
        public double? Ipi { get; set; }
        public decimal? Valor { get; set; }
        public double? QtdVolume { get; set; }
        public string Modalidade { get; set; }
        public string Cst { get; set; }
        public double? AliqIpi { get; set; }
        public double? ValorIpi { get; set; }
        public double? BaseCalcIpi { get; set; }
        public double? ValorIcms { get; set; }
        public double? BaseCalcIcms { get; set; }
        public double? AliqIcms { get; set; }
        public double? RedIcms { get; set; }
        public double? AliqPis { get; set; }
        public double? ValorPis { get; set; }
        public double? AliqCofins { get; set; }
        public double? ValorCofins { get; set; }
        public int? Origem { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public decimal? ValorFrete { get; set; }
        public string CstIpi { get; set; }
        public string CstPis { get; set; }
        public string CstCofins { get; set; }
    }
}
