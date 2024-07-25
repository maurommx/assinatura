using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class EtiquetasVolume
    {
        public int Id { get; set; }
        public string Nf { get; set; }
        public string Empresa { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Volume { get; set; }
        public string PortaImpressao { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public bool? Impresso { get; set; }
        public bool? Liberado { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
