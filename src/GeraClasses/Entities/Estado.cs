using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Estado
    {
        public Estado()
        {
            Cidades = new HashSet<Cidade>();
        }

        public int Id { get; set; }
        public string Uf { get; set; }
        public string Descricao { get; set; }
        public string CodigoIbge { get; set; }
        public int? DiasEntrega { get; set; }
        public bool? ConsultaCnpj { get; set; }
        public bool? ConsultaCpf { get; set; }
        public decimal? Frete { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
