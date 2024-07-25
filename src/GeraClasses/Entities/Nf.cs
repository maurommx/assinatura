using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Nf
    {
        public Nf()
        {
            Boletos = new HashSet<Boleto>();
            NfCces = new HashSet<NfCce>();
            Recebers = new HashSet<Receber>();
        }

        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public int? IdPedidoFechado { get; set; }
        public int? IdCfop { get; set; }
        public double? Icms { get; set; }
        public int? IdCliente { get; set; }
        public int? IdFornecedor { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? HoraEmissao { get; set; }
        public DateTime? DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public DateTime? HoraSaida { get; set; }
        public double? BaseCalculoIcms { get; set; }
        public double? ValorIcms { get; set; }
        public decimal? ValorTotalProdutos { get; set; }
        public decimal? ValorFrete { get; set; }
        public decimal? ValorSeguro { get; set; }
        public decimal? OutrasDespesas { get; set; }
        public decimal? ValorTotalNota { get; set; }
        public int? IdTransportadora { get; set; }
        public int? IdRedespacho { get; set; }
        public bool? FretePorConta { get; set; }
        public string PlacaVeiculo { get; set; }
        public string PlacaVeiculoUf { get; set; }
        public double? Qtda { get; set; }
        public string Especie { get; set; }
        public string Marca { get; set; }
        public string NumeroTransportadora { get; set; }
        public double? PesoBruto { get; set; }
        public double? PesoLiquido { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? Aumento { get; set; }
        public int? IdRepresentante { get; set; }
        public string Obs { get; set; }
        public string Obs1 { get; set; }
        public string Obs2 { get; set; }
        public bool? ConverteVolume { get; set; }
        public int? FormaPagamento { get; set; }
        public DateTime? Vencimento01 { get; set; }
        public decimal? Valor01 { get; set; }
        public DateTime? Vencimento02 { get; set; }
        public decimal? Valor02 { get; set; }
        public DateTime? Vencimento03 { get; set; }
        public decimal? Valor03 { get; set; }
        public DateTime? Vencimento04 { get; set; }
        public decimal? Valor04 { get; set; }
        public DateTime? Vencimento05 { get; set; }
        public decimal? Valor05 { get; set; }
        public DateTime? Vencimento06 { get; set; }
        public decimal? Valor06 { get; set; }
        public bool? Impresso { get; set; }
        public string Pagamento { get; set; }
        public int? IdConta { get; set; }
        public string Pagamentos { get; set; }
        public double? Cst { get; set; }
        public bool? Manual { get; set; }
        public double? AliqIcms { get; set; }
        public double? RedIcms { get; set; }
        public double? ValorIcmsSubstituicao { get; set; }
        public double? BaseCalculoIcmsSubstituicao { get; set; }
        public double? ValorTotalIpi { get; set; }
        public bool? ImpExt { get; set; }
        public bool? EnviadaNfe { get; set; }
        public bool? PagOutros { get; set; }
        public string Autorizacao { get; set; }
        public string Protocolo { get; set; }
        public string DataProtocolo { get; set; }
        public bool? ImpDanfe { get; set; }
        public int? IdDest { get; set; }
        public int? IndFinal { get; set; }
        public int? IndPres { get; set; }
        public Guid? MsreplTranVersion { get; set; }
        public string Serie { get; set; }
        public DateTime? DataEmbarque { get; set; }
        public DateTime? DataEntrega { get; set; }
        public bool? Entregue { get; set; }
        public string Dv { get; set; }
        public DateTime? DataTransferencia { get; set; }
        public bool? Transferido { get; set; }

        public virtual ICollection<Boleto> Boletos { get; set; }
        public virtual ICollection<NfCce> NfCces { get; set; }
        public virtual ICollection<Receber> Recebers { get; set; }
    }
}
