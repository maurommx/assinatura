using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Unidade
    {
        public Unidade()
        {
            Insumos = new HashSet<Insumo>();
            NfCanceladasItens = new HashSet<NfCanceladasIten>();
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Abreviado { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Insumo> Insumos { get; set; }
        public virtual ICollection<NfCanceladasIten> NfCanceladasItens { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
