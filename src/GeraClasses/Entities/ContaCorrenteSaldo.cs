using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class ContaCorrenteSaldo
    {
        public int Id { get; set; }
        public int? IdConta { get; set; }
        public DateTime? Data { get; set; }
        public decimal? Saldo { get; set; }

        public virtual Conta IdContaNavigation { get; set; }
    }
}
