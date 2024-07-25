using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class DivisoesCore
    {
        public int Id { get; set; }
        public int? IdDivisao { get; set; }
        public int? IdCor { get; set; }
        public string Tonalidade { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Core IdCorNavigation { get; set; }
        public virtual Diviso IdDivisaoNavigation { get; set; }
    }
}
