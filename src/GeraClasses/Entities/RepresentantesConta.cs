using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class RepresentantesConta
    {
        public int Id { get; set; }
        public int? IdRepresentante { get; set; }
        public int? IdBanco { get; set; }
        public int? IdOutroBanco { get; set; }
        public string Agencia { get; set; }
        public string DigitoAgencia { get; set; }
        public string NomeAgencia { get; set; }
        public string Telefone { get; set; }
        public string Tipo { get; set; }
        public string Conta { get; set; }
        public string DigitoConta { get; set; }
        public string Titular { get; set; }
        public DateTime? ContaDesde { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Banco IdBancoNavigation { get; set; }
        public virtual Banco IdOutroBancoNavigation { get; set; }
        public virtual Representante IdRepresentanteNavigation { get; set; }
    }
}
