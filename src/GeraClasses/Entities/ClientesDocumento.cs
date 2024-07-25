using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class ClientesDocumento
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? Data { get; set; }
        public string Obs { get; set; }
        public string Extensao { get; set; }
    }
}
