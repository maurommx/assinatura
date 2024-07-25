using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class DespesasGrupo
    {
        public DespesasGrupo()
        {
            Despesas = new HashSet<Despesa>();
        }

        public int Id { get; set; }
        public int? IdSetor { get; set; }
        public int? IdDepartamento { get; set; }
        public string Descricao { get; set; }
        public string ContaContabil { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; }
        public virtual Setore IdSetorNavigation { get; set; }
        public virtual ICollection<Despesa> Despesas { get; set; }
    }
}
