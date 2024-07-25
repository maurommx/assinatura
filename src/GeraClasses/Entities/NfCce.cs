using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class NfCce
    {
        public int Id { get; set; }
        public int? IdNota { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public string Orgao { get; set; }
        public int? Sequencia { get; set; }
        public string Texto { get; set; }
        public int? Lote { get; set; }
        public string Fuso { get; set; }
        public string Protocolo { get; set; }

        public virtual Nf IdNotaNavigation { get; set; }
    }
}
