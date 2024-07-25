using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class TransportadorasContato
    {
        public int Id { get; set; }
        public int? IdTransportadora { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Matriz { get; set; }
        public string Uf { get; set; }
        public string Sigla { get; set; }
        public string Telefone { get; set; }
        public string Ramal { get; set; }
        public string Fax { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string ContatoTipo { get; set; }
        public string ContatoId { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Transportadora IdTransportadoraNavigation { get; set; }
    }
}
