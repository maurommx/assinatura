using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Pagar
    {
        public int Id { get; set; }
        public int? IdFornecedor { get; set; }
        public string Nf { get; set; }
        public string Parcela { get; set; }
        public DateTime? DataVencimento { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? Juros { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? ValorPago { get; set; }
        public string Ncheque { get; set; }
        public int? IdConta { get; set; }
        public int? IdForma { get; set; }
        public int? IdGrupoDespesa { get; set; }
        public int? IdDespesa { get; set; }
        public DateTime? DataEmissao { get; set; }
        public string Observacao { get; set; }
        public DateTime? Entrada { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public decimal? ValorOriginal { get; set; }

        public virtual Fornecedore IdFornecedorNavigation { get; set; }
    }
}
