using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class ImpNf
    {
        public int Id { get; set; }
        public int? IdNf { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public bool? Impresso { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
