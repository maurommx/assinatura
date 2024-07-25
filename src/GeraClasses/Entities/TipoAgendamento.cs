using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class TipoAgendamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool? Bloqueado { get; set; }
    }
}
