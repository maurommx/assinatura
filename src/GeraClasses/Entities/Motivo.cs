using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Motivo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Abreviado { get; set; }
        public string Descricao { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
