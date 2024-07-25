using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class VendasPedidosIten
    {
        public VendasPedidosIten()
        {
            Producaos = new HashSet<Producao>();
            VendasPedidosFechadosPedidosItens = new HashSet<VendasPedidosFechadosPedidosIten>();
        }

        public int Id { get; set; }
        public int? IdPedido { get; set; }
        public int? IdProduto { get; set; }
        public int? IdCor { get; set; }
        public int? IdStatus { get; set; }
        public double? Qtda { get; set; }
        public double? QtdaFaturado { get; set; }
        public double? Valor { get; set; }
        public double? Total { get; set; }
        public bool? Urgente { get; set; }
        public bool? Faturado { get; set; }
        public double? QtdaProduzido { get; set; }
        public DateTime? Produzido { get; set; }
        public DateTime? UltDataProducao { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Producao> Producaos { get; set; }
        public virtual ICollection<VendasPedidosFechadosPedidosIten> VendasPedidosFechadosPedidosItens { get; set; }
    }
}
