using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class RepresentantesProdutosDesconto
    {
        public int Id { get; set; }
        public int? IdRepresentante { get; set; }
        public int? IdProduto { get; set; }
        public double? Desconto { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual Representante IdRepresentanteNavigation { get; set; }
    }
}
