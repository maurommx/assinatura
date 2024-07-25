using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class VendasPedidosFechadosPedido
    {
        public VendasPedidosFechadosPedido()
        {
            Producaos = new HashSet<Producao>();
            VendasPedidosFechadosPedidosItens = new HashSet<VendasPedidosFechadosPedidosIten>();
        }

        public int Id { get; set; }
        public int? IdPedidoFechado { get; set; }
        public int? IdPedido { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual VendasPedidosFechado IdPedidoFechadoNavigation { get; set; }
        public virtual VendasPedido IdPedidoNavigation { get; set; }
        public virtual ICollection<Producao> Producaos { get; set; }
        public virtual ICollection<VendasPedidosFechadosPedidosIten> VendasPedidosFechadosPedidosItens { get; set; }
    }
}
