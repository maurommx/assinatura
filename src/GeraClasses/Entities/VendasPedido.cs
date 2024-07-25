using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class VendasPedido
    {
        public VendasPedido()
        {
            Producaos = new HashSet<Producao>();
            VendasPedidosFechadosPedidos = new HashSet<VendasPedidosFechadosPedido>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string CodRep { get; set; }
        public int? IdCliente { get; set; }
        public int? IdStatus { get; set; }
        public int? IdRepresentante { get; set; }
        public int? IdTransportadora { get; set; }
        public string FreteTransportadora { get; set; }
        public int? IdRedespacho { get; set; }
        public string FreteRedespacho { get; set; }
        public int? FormaPagamento { get; set; }
        public int? Prazo1 { get; set; }
        public int? Prazo2 { get; set; }
        public int? Prazo3 { get; set; }
        public int? Prazo4 { get; set; }
        public int? Prazo5 { get; set; }
        public int? Prazo6 { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Emissao { get; set; }
        public DateTime? Cadastrado { get; set; }
        public DateTime? Liberado { get; set; }
        public bool? Liberar { get; set; }
        public DateTime? Aberto { get; set; }
        public DateTime? Fechado { get; set; }
        public DateTime? Faturado { get; set; }
        public DateTime? Embarcado { get; set; }
        public DateTime? Rejeitado { get; set; }
        public bool? Rejeitar { get; set; }
        public bool? Saldo { get; set; }
        public string Obs { get; set; }
        public bool? PedidoFinalizado { get; set; }
        public bool? EmAtraso { get; set; }
        public bool? Executado { get; set; }
        public bool? Bloqueado { get; set; }
        public bool? Polycron { get; set; }
        public bool? Faturado1 { get; set; }
        public string ObsAberto { get; set; }
        public bool? Msg { get; set; }
        public bool? TxFrete { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public string PedidoCompra { get; set; }
        public int? VolumesExtra { get; set; }
        public DateTime? PrevisaoFaturamento { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? EmissaoAntes { get; set; }
        public decimal? ValorFrete { get; set; }

        public virtual ClientesUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Producao> Producaos { get; set; }
        public virtual ICollection<VendasPedidosFechadosPedido> VendasPedidosFechadosPedidos { get; set; }
    }
}
