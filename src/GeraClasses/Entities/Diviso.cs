using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Diviso
    {
        public Diviso()
        {
            DivisoesCores = new HashSet<DivisoesCore>();
            Fabricas = new HashSet<Fabrica>();
            Setores = new HashSet<Setore>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal? Cota { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual ICollection<DivisoesCore> DivisoesCores { get; set; }
        public virtual ICollection<Fabrica> Fabricas { get; set; }
        public virtual ICollection<Setore> Setores { get; set; }
    }
}
