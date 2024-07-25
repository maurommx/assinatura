using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Fabrica
    {
        public Fabrica()
        {
            FuncionariosFabricas = new HashSet<FuncionariosFabrica>();
            Produtos = new HashSet<Produto>();
            Setores = new HashSet<Setore>();
        }

        public int Id { get; set; }
        public int? IdDivisao { get; set; }
        public string Descricao { get; set; }
        public string Resumido { get; set; }
        public int? Limite { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual Diviso IdDivisaoNavigation { get; set; }
        public virtual ICollection<FuncionariosFabrica> FuncionariosFabricas { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<Setore> Setores { get; set; }
    }
}
