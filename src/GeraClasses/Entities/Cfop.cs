using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Cfop
    {
        public Cfop()
        {
            CfopItens = new HashSet<CfopIten>();
            NfEntrada = new HashSet<NfEntradum>();
            NfEntradaItens = new HashSet<NfEntradaIten>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool? Entrada { get; set; }
        public int? IdDest { get; set; }
        public bool? Devolucao { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<CfopIten> CfopItens { get; set; }
        public virtual ICollection<NfEntradum> NfEntrada { get; set; }
        public virtual ICollection<NfEntradaIten> NfEntradaItens { get; set; }
    }
}
