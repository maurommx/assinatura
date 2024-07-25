using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Producao
    {
        public int IdProducao { get; set; }
        public int? IdPedido { get; set; }
        public int? IdPedidoFechado { get; set; }
        public int? IdPedidoFechadoPedidos { get; set; }
        public int? IdItem { get; set; }
        public int? IdItemFechado { get; set; }
        public int? IdProduto { get; set; }
        public int? IdCor { get; set; }
        public int? IdFuncionario { get; set; }
        public double? Qtda { get; set; }
        public DateTime? Data { get; set; }

        public virtual Core IdCorNavigation { get; set; }
        public virtual Funcionario IdFuncionarioNavigation { get; set; }
        public virtual VendasPedidosFechadosPedidosIten IdItemFechadoNavigation { get; set; }
        public virtual VendasPedidosIten IdItemNavigation { get; set; }
        public virtual VendasPedidosFechado IdPedidoFechadoNavigation { get; set; }
        public virtual VendasPedidosFechadosPedido IdPedidoFechadoPedidosNavigation { get; set; }
        public virtual VendasPedido IdPedidoNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
