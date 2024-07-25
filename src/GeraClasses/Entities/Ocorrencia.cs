using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Ocorrencia
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public int? IdFornecedor { get; set; }
        public int? IdFuncionario { get; set; }
        public int? IdRepresentante { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public string Texto { get; set; }
        public string Funcionario { get; set; }
        public bool? Executado { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Fornecedore IdFornecedorNavigation { get; set; }
    }
}
