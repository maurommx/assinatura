using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class ClientesUsuario
    {
        public ClientesUsuario()
        {
            VendasPedidos = new HashSet<VendasPedido>();
        }

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public bool? Expirou { get; set; }
        public DateTime? UltimoLogin { get; set; }
        public bool? Bloqueado { get; set; }
        public bool? MnuPedidos { get; set; }
        public bool? MnuLevantamento { get; set; }
        public bool? MnuUsuarios { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<VendasPedido> VendasPedidos { get; set; }
    }
}
