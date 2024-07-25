using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class TabelaPrecoProduto
    {
        public int Id { get; set; }
        public int? IdTabela { get; set; }
        public int? IdProduto { get; set; }
        public decimal? Preco { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual TabelaPreco IdTabelaNavigation { get; set; }
    }
}
