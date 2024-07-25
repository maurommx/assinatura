using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Despesa
    {
        public int Id { get; set; }
        public int? IdGrupo { get; set; }
        public string Descricao { get; set; }
        public string ContaContabil { get; set; }
        public bool? Custo { get; set; }
        public bool? Custo1 { get; set; }
        public bool? Fio { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public int? IdHistoricoContabil { get; set; }

        public virtual DespesasGrupo IdGrupoNavigation { get; set; }
    }
}
