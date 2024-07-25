using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class OcorrenciasConsumidor
    {
        public int Id { get; set; }
        public int? IdConsumidor { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public string Texto { get; set; }
        public string Funcionario { get; set; }
        public bool? Executado { get; set; }

        public virtual Consumidore IdConsumidorNavigation { get; set; }
    }
}
