using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class OcorrenciasPedidosFechado
    {
        public int Id { get; set; }
        public int? IdPedido { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public string Texto { get; set; }
        public string Funcionario { get; set; }
        public bool? Executado { get; set; }

        public virtual VendasPedidosFechado IdPedidoNavigation { get; set; }
    }
}
