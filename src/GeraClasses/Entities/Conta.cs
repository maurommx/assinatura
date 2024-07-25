using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Conta
    {
        public Conta()
        {
            Boletos = new HashSet<Boleto>();
            ContaCorrenteSaldos = new HashSet<ContaCorrenteSaldo>();
            Recebers = new HashSet<Receber>();
            TransferenciaIdContaDestinoNavigations = new HashSet<Transferencia>();
            TransferenciaIdContaOrigemNavigations = new HashSet<Transferencia>();
        }

        public int Id { get; set; }
        public int? IdBanco { get; set; }
        public decimal? Saldo { get; set; }
        public string CodigoEmpresa { get; set; }
        public string Agencia { get; set; }
        public string DigitoAgencia { get; set; }
        public string NomeAgencia { get; set; }
        public string Telefone { get; set; }
        public string Tipo { get; set; }
        public string Conta1 { get; set; }
        public string DigitoConta { get; set; }
        public string Titular { get; set; }
        public DateTime? ContaDesde { get; set; }
        public string Carteira { get; set; }
        public string Variacao { get; set; }
        public bool? Bloqueado { get; set; }
        public bool? Cobranca { get; set; }
        public bool? Pagamento { get; set; }
        public string Mensagem { get; set; }
        public string Complementar { get; set; }
        public double? Juros { get; set; }
        public string NossoNumero { get; set; }
        public string Sequencial { get; set; }
        public string ContaContabil { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public decimal? SaldoAntecipado { get; set; }
        public bool? DiaSeguinte { get; set; }
        public bool? Investimento { get; set; }
        public decimal? Multa { get; set; }

        public virtual Banco IdBancoNavigation { get; set; }
        public virtual ICollection<Boleto> Boletos { get; set; }
        public virtual ICollection<ContaCorrenteSaldo> ContaCorrenteSaldos { get; set; }
        public virtual ICollection<Receber> Recebers { get; set; }
        public virtual ICollection<Transferencia> TransferenciaIdContaDestinoNavigations { get; set; }
        public virtual ICollection<Transferencia> TransferenciaIdContaOrigemNavigations { get; set; }
    }
}
