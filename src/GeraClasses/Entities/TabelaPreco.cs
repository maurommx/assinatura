using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class TabelaPreco
    {
        public TabelaPreco()
        {
            Representantes = new HashSet<Representante>();
            TabelaPrecoProdutos = new HashSet<TabelaPrecoProduto>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Representante> Representantes { get; set; }
        public virtual ICollection<TabelaPrecoProduto> TabelaPrecoProdutos { get; set; }
    }
}
