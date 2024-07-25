using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Logradouro
    {
        public int Id { get; set; }
        public int? IdCidade { get; set; }
        public int? IdBairro { get; set; }
        public string DescricaoNaoAbreviada { get; set; }
        public string Descricao { get; set; }
        public string Cep { get; set; }
        public string LogComplemento { get; set; }
        public string LogTipoLogradouro { get; set; }
        public string LogStatusTipoLog { get; set; }
        public string DescricaoSemAcento { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Bairro IdBairroNavigation { get; set; }
        public virtual Cidade IdCidadeNavigation { get; set; }
    }
}
