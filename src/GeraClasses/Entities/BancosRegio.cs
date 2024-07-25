using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class BancosRegio
    {
        public int Id { get; set; }
        public int? IdBanco { get; set; }
        public string Cep { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Banco IdBancoNavigation { get; set; }
    }
}
