using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class VendasPedidosFechadosFabrica
    {
        public int IdPedidoFechadoFabrica { get; set; }
        public int? IdPedidoFechado { get; set; }
        public int? IdFabrica { get; set; }
        public DateTime? Data { get; set; }
        public int? IdFuncionario { get; set; }
        public string Corredor { get; set; }

        public virtual VendasPedidosFechado IdPedidoFechadoNavigation { get; set; }
    }
}
