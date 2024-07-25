using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class ClientesProdutosDesconto
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public int? IdProduto { get; set; }
        public double? Desconto { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
