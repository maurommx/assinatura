using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class RepresentantesRegio
    {
        public int Id { get; set; }
        public int? IdRepresentante { get; set; }
        public string Cep { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Representante IdRepresentanteNavigation { get; set; }
    }
}
