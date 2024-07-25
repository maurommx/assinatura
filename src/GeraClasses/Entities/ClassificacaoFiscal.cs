using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class ClassificacaoFiscal
    {
        public ClassificacaoFiscal()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string Letra { get; set; }
        public string Ncm { get; set; }
        public string Descricao { get; set; }
        public double? Ipi { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
