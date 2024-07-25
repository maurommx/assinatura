using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Remessa
    {
        public Remessa()
        {
            Boletos = new HashSet<Boleto>();
            Recebers = new HashSet<Receber>();
        }

        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public string Sequencial { get; set; }
        public bool? Reenvio { get; set; }
        public string Arquivo { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Boleto> Boletos { get; set; }
        public virtual ICollection<Receber> Recebers { get; set; }
    }
}
