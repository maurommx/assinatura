using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Bairro
    {
        public Bairro()
        {
            ClientesConta = new HashSet<ClientesConta>();
            Logradouros = new HashSet<Logradouro>();
        }

        public int Id { get; set; }
        public int? IdCidade { get; set; }
        public string Descricao { get; set; }
        public string Abreviado { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Cidade IdCidadeNavigation { get; set; }
        public virtual ICollection<ClientesConta> ClientesConta { get; set; }
        public virtual ICollection<Logradouro> Logradouros { get; set; }
    }
}
