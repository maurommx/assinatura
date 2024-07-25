using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Saldo
    {
        public Saldo()
        {
            Lancamentos = new HashSet<Lancamento>();
        }

        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public decimal? SaldoAnterior { get; set; }
        public decimal? Entrada { get; set; }
        public decimal? Saida { get; set; }
        public decimal? Saldo1 { get; set; }
        public bool? Fechado { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
