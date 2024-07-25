using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class NfInutilizacao
    {
        public int Id { get; set; }
        public int? IdEmrpesa { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }
        public string Serie { get; set; }
        public string Ano { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public string Texto { get; set; }
        public string Protocolo { get; set; }
    }
}
