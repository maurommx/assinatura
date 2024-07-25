using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Cidade
    {
        public Cidade()
        {
            Bairros = new HashSet<Bairro>();
            Logradouros = new HashSet<Logradouro>();
        }

        public int Id { get; set; }
        public int? IdEstado { get; set; }
        public string Descricao { get; set; }
        public string DescricaoB { get; set; }
        public string Cep { get; set; }
        public int Situacao { get; set; }
        public string TipoLocalidade { get; set; }
        public int? LocNuSequencialSub { get; set; }
        public string CodIbge { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual ICollection<Bairro> Bairros { get; set; }
        public virtual ICollection<Logradouro> Logradouros { get; set; }
    }
}
