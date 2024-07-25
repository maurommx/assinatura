using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class MotivosBanco
    {
        public MotivosBanco()
        {
            ReceberIdMotivo1Navigations = new HashSet<Receber>();
            ReceberIdMotivo2Navigations = new HashSet<Receber>();
            ReceberIdMotivo3Navigations = new HashSet<Receber>();
            ReceberIdMotivo4Navigations = new HashSet<Receber>();
            ReceberIdMotivo5Navigations = new HashSet<Receber>();
        }

        public int Id { get; set; }
        public int? IdOcorrencia { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual OcorrenciasBanco IdOcorrenciaNavigation { get; set; }
        public virtual ICollection<Receber> ReceberIdMotivo1Navigations { get; set; }
        public virtual ICollection<Receber> ReceberIdMotivo2Navigations { get; set; }
        public virtual ICollection<Receber> ReceberIdMotivo3Navigations { get; set; }
        public virtual ICollection<Receber> ReceberIdMotivo4Navigations { get; set; }
        public virtual ICollection<Receber> ReceberIdMotivo5Navigations { get; set; }
    }
}
