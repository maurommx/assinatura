using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class VendasPedidosFechadosExtra
    {
        public int Id { get; set; }
        public int? IdPedidoFechado { get; set; }
        public int? IdExtra { get; set; }
        public DateTime? Data { get; set; }
        public int? IdFuncionario { get; set; }
        public int? Qtda { get; set; }

        public virtual VendasPedidosFechado IdPedidoFechadoNavigation { get; set; }
    }
}
