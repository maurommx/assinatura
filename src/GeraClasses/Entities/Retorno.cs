using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Retorno
    {
        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public string Arquivo { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
