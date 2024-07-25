using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Receber
    {
        public int Id { get; set; }
        public int? IdNota { get; set; }
        public int? IdBoleto { get; set; }
        public int? IdConta { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public DateTime? Emissao { get; set; }
        public DateTime? VencimentoOriginal { get; set; }
        public DateTime? Vencimento { get; set; }
        public string NossoNumero { get; set; }
        public decimal? ValorPago { get; set; }
        public decimal? ValorOriginal { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Juros { get; set; }
        public decimal? Desconto { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public DateTime? DataOcorrencia { get; set; }
        public int? IdOcorrencia { get; set; }
        public int? IdMotivo1 { get; set; }
        public int? IdMotivo2 { get; set; }
        public int? IdMotivo3 { get; set; }
        public int? IdMotivo4 { get; set; }
        public int? IdMotivo5 { get; set; }
        public string Parcela { get; set; }
        public int? IdCliente { get; set; }
        public string Nf { get; set; }
        public string Cheque { get; set; }
        public int? IdFormaPagamento { get; set; }
        public bool? Baixado { get; set; }
        public string Obs { get; set; }
        public bool? Nc { get; set; }
        public bool? GeradoArquivo { get; set; }
        public bool? Boleto { get; set; }
        public int? IdRemessa { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Conta IdContaNavigation { get; set; }
        public virtual FormaPagamento IdFormaPagamentoNavigation { get; set; }
        public virtual MotivosBanco IdMotivo1Navigation { get; set; }
        public virtual MotivosBanco IdMotivo2Navigation { get; set; }
        public virtual MotivosBanco IdMotivo3Navigation { get; set; }
        public virtual MotivosBanco IdMotivo4Navigation { get; set; }
        public virtual MotivosBanco IdMotivo5Navigation { get; set; }
        public virtual Nf IdNotaNavigation { get; set; }
        public virtual OcorrenciasBanco IdOcorrenciaNavigation { get; set; }
        public virtual Remessa IdRemessaNavigation { get; set; }
    }
}
