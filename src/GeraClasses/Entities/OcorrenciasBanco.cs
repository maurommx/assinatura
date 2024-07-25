using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class OcorrenciasBanco
    {
        public OcorrenciasBanco()
        {
            MotivosBancos = new HashSet<MotivosBanco>();
            Recebers = new HashSet<Receber>();
        }

        public int Id { get; set; }
        public int? IdBanco { get; set; }
        public string CodBanco { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool? Motivo { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<MotivosBanco> MotivosBancos { get; set; }
        public virtual ICollection<Receber> Recebers { get; set; }
    }
}
