using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Setore
    {
        public Setore()
        {
            DespesasGrupos = new HashSet<DespesasGrupo>();
            Funcionarios = new HashSet<Funcionario>();
        }

        public int Id { get; set; }
        public int? IdDivisao { get; set; }
        public int? IdFabrica { get; set; }
        public string Descricao { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual Diviso IdDivisaoNavigation { get; set; }
        public virtual Fabrica IdFabricaNavigation { get; set; }
        public virtual ICollection<DespesasGrupo> DespesasGrupos { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
