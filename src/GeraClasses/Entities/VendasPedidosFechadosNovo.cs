using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class VendasPedidosFechadosNovo
    {
        public int Id { get; set; }
        public int? IdPedidoFechado { get; set; }
        public int? IdCoordenador { get; set; }
    }
}
