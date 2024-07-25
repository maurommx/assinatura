using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class ImpBoleto
    {
        public int Id { get; set; }
        public int? IdReceber { get; set; }
        public int? IdBoleto { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public bool? Impresso { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
