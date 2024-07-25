using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class ClientesAlteracaoTabelaPreco
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? Data { get; set; }
        public string Usuario { get; set; }
        public int? IdTabelaAnterior { get; set; }
        public int? IdTabelaAtual { get; set; }
    }
}
