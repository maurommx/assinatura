using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Lancamento
    {
        public int Id { get; set; }
        public int? IdSaldo { get; set; }
        public DateTime? Data { get; set; }
        public string Conta { get; set; }
        public string ContaContabil { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public decimal? Valor { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Saldo IdSaldoNavigation { get; set; }
    }
}
