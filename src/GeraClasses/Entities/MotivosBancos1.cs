using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class MotivosBancos1
    {
        public int Id { get; set; }
        public int? IdOcorrencia { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
