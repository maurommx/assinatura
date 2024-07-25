using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class NfReferenciada
    {
        public int Id { get; set; }
        public int? IdNf { get; set; }
        public bool? TipoNfe { get; set; }
        public string Nfe { get; set; }
        public string Uf { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }
        public string Cnpj { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Nf { get; set; }
    }
}
