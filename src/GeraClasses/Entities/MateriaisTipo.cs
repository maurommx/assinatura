using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class MateriaisTipo
    {
        public MateriaisTipo()
        {
            Insumos = new HashSet<Insumo>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? IdMateriaisGrupo { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Insumo> Insumos { get; set; }
    }
}
