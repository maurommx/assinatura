using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class VwCep
    {
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string CepLogradouro { get; set; }
        public string CepCidade { get; set; }
    }
}
