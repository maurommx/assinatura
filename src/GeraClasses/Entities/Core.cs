using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Core
    {
        public Core()
        {
            DivisoesCores = new HashSet<DivisoesCore>();
            Producaos = new HashSet<Producao>();
            VendasPedidosFechadosPedidosItens = new HashSet<VendasPedidosFechadosPedidosIten>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<DivisoesCore> DivisoesCores { get; set; }
        public virtual ICollection<Producao> Producaos { get; set; }
        public virtual ICollection<VendasPedidosFechadosPedidosIten> VendasPedidosFechadosPedidosItens { get; set; }
    }
}
