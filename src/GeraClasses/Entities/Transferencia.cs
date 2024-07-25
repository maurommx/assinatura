using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Transferencia
    {
        public int Id { get; set; }
        public int? IdContaOrigem { get; set; }
        public int? IdContaDestino { get; set; }
        public DateTime? Data { get; set; }
        public decimal? Valor { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Conta IdContaDestinoNavigation { get; set; }
        public virtual Conta IdContaOrigemNavigation { get; set; }
    }
}
