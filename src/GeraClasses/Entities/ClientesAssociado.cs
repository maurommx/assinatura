using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class ClientesAssociado
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public int? IdClienteAssociado { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Cliente IdClienteAssociadoNavigation { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
