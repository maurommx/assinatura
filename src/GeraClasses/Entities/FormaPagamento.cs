using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class FormaPagamento
    {
        public FormaPagamento()
        {
            Recebers = new HashSet<Receber>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool? Automatico { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Receber> Recebers { get; set; }
    }
}
