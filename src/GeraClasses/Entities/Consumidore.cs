using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Consumidore
    {
        public Consumidore()
        {
            OcorrenciasConsumidors = new HashSet<OcorrenciasConsumidor>();
        }

        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public string RazaoSocial { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public string Distribuidor { get; set; }
        public DateTime? DataFundacao { get; set; }
        public bool? Liberado { get; set; }
        public bool? Bloqueado { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool? Kron { get; set; }
        public bool? Polycron { get; set; }
        public bool? Ricamare { get; set; }
        public bool? Vip { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<OcorrenciasConsumidor> OcorrenciasConsumidors { get; set; }
    }
}
