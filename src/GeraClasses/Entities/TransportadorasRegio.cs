using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class TransportadorasRegio
    {
        public int Id { get; set; }
        public int? IdTransportadora { get; set; }
        public string Cep { get; set; }
        public string Matriz { get; set; }
        public string Uf { get; set; }
        public string Sigla { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Transportadora IdTransportadoraNavigation { get; set; }
    }
}
