using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class VendasPedidosFechadosAlerta
    {
        public int Id { get; set; }
        public int? IdFuncionario { get; set; }
        public int? IdPedido { get; set; }
        public bool? Enviado { get; set; }
        public DateTime? DataEnvio { get; set; }
        public bool? Lido { get; set; }
        public DateTime? DataLeitura { get; set; }

        public virtual Funcionario IdFuncionarioNavigation { get; set; }
        public virtual VendasPedidosFechado IdPedidoNavigation { get; set; }
    }
}
