using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class TransportadorasColetum
    {
        public int Id { get; set; }
        public int? IdTransportadora { get; set; }
        public bool? Segunda { get; set; }
        public bool? Terca { get; set; }
        public bool? Quarta { get; set; }
        public bool? Quinta { get; set; }
        public bool? Sexta { get; set; }
        public bool? Sabado { get; set; }
        public bool? Domingo { get; set; }
    }
}
