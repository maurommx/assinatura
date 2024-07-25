using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Paise
    {
        public int Id { get; set; }
        public string CodIbge { get; set; }
        public string Descricao { get; set; }
        public bool? TributacaoFavorecida { get; set; }
    }
}
