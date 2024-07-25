using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class VendasPedidosFechadosPedidosIten
    {
        public VendasPedidosFechadosPedidosIten()
        {
            Producaos = new HashSet<Producao>();
        }

        public int Id { get; set; }
        public int? IdVendasPedidosItem { get; set; }
        public int? IdPedidoFechado { get; set; }
        public int? IdPedidoFechadoPedido { get; set; }
        public int? IdProduto { get; set; }
        public int? IdCor { get; set; }
        public double? Qtda { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public bool? Conferido { get; set; }
        public int? IdConferente { get; set; }
        public DateTime? DataConferencia { get; set; }

        public virtual Funcionario IdConferenteNavigation { get; set; }
        public virtual Core IdCorNavigation { get; set; }
        public virtual VendasPedidosFechado IdPedidoFechadoNavigation { get; set; }
        public virtual VendasPedidosFechadosPedido IdPedidoFechadoPedidoNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual VendasPedidosIten IdVendasPedidosItemNavigation { get; set; }
        public virtual ICollection<Producao> Producaos { get; set; }
    }
}
