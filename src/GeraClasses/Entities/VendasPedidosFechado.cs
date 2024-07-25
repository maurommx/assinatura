using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class VendasPedidosFechado
    {
        public VendasPedidosFechado()
        {
            OcorrenciasPedidosFechados = new HashSet<OcorrenciasPedidosFechado>();
            Producaos = new HashSet<Producao>();
            VendasPedidosFechadosAlerta = new HashSet<VendasPedidosFechadosAlerta>();
            VendasPedidosFechadosExtras = new HashSet<VendasPedidosFechadosExtra>();
            VendasPedidosFechadosFabricas = new HashSet<VendasPedidosFechadosFabrica>();
            VendasPedidosFechadosPedidos = new HashSet<VendasPedidosFechadosPedido>();
            VendasPedidosFechadosPedidosItens = new HashSet<VendasPedidosFechadosPedidosIten>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string CodRep { get; set; }
        public int? IdCliente { get; set; }
        public int? IdTransportadora { get; set; }
        public int? Volumes { get; set; }
        public DateTime? Data { get; set; }
        public string Obs { get; set; }
        public int? FormaPagamento { get; set; }
        public int? Prazo1 { get; set; }
        public int? Prazo2 { get; set; }
        public int? Prazo3 { get; set; }
        public int? Prazo4 { get; set; }
        public int? Prazo5 { get; set; }
        public int? Prazo6 { get; set; }
        public string Cep { get; set; }
        public bool? Finalizado { get; set; }
        public bool? Faturado { get; set; }
        public int? VolumesExtra { get; set; }
        public DateTime? PrevisaoFaturamento { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public DateTime? HoraFechamento { get; set; }
        public int? IdFuncionario { get; set; }
        public DateTime? Hora { get; set; }
        public bool? Saldo { get; set; }
        public bool? Novo { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Transportadora IdTransportadoraNavigation { get; set; }
        public virtual ICollection<OcorrenciasPedidosFechado> OcorrenciasPedidosFechados { get; set; }
        public virtual ICollection<Producao> Producaos { get; set; }
        public virtual ICollection<VendasPedidosFechadosAlerta> VendasPedidosFechadosAlerta { get; set; }
        public virtual ICollection<VendasPedidosFechadosExtra> VendasPedidosFechadosExtras { get; set; }
        public virtual ICollection<VendasPedidosFechadosFabrica> VendasPedidosFechadosFabricas { get; set; }
        public virtual ICollection<VendasPedidosFechadosPedido> VendasPedidosFechadosPedidos { get; set; }
        public virtual ICollection<VendasPedidosFechadosPedidosIten> VendasPedidosFechadosPedidosItens { get; set; }
    }
}
