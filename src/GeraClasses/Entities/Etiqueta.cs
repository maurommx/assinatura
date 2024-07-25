using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Etiqueta
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public int? IdFornecedor { get; set; }
        public int? IdRepresentante { get; set; }
        public string Tipo { get; set; }
        public string PortaImpressao { get; set; }
        public bool? Impresso { get; set; }
        public bool? Liberado { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
