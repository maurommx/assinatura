using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Banco
    {
        public Banco()
        {
            BancosRegios = new HashSet<BancosRegio>();
            ClientesConta = new HashSet<ClientesConta>();
            Conta = new HashSet<Conta>();
            FornecedoresContaIdBancoNavigations = new HashSet<FornecedoresConta>();
            FornecedoresContaIdOutroBancoNavigations = new HashSet<FornecedoresConta>();
            RepresentantesContaIdBancoNavigations = new HashSet<RepresentantesConta>();
            RepresentantesContaIdOutroBancoNavigations = new HashSet<RepresentantesConta>();
            TransportadorasContaIdBancoNavigations = new HashSet<TransportadorasConta>();
            TransportadorasContaIdOutroBancoNavigations = new HashSet<TransportadorasConta>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Sequencial { get; set; }
        public string NossoNumero { get; set; }
        public bool? Boleto { get; set; }
        public string ContaContabil { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public bool? DiaSeguinte { get; set; }
        public int? Banco1 { get; set; }
        public int? ValorX { get; set; }
        public int? ValorY { get; set; }
        public int? ExtensoX { get; set; }
        public int? ExtensoY { get; set; }
        public int? NominalX { get; set; }
        public int? NominalY { get; set; }
        public int? LocalX { get; set; }
        public int? LocalY { get; set; }
        public int? DiaX { get; set; }
        public int? MesX { get; set; }
        public int? AnoX { get; set; }

        public virtual ICollection<BancosRegio> BancosRegios { get; set; }
        public virtual ICollection<ClientesConta> ClientesConta { get; set; }
        public virtual ICollection<Conta> Conta { get; set; }
        public virtual ICollection<FornecedoresConta> FornecedoresContaIdBancoNavigations { get; set; }
        public virtual ICollection<FornecedoresConta> FornecedoresContaIdOutroBancoNavigations { get; set; }
        public virtual ICollection<RepresentantesConta> RepresentantesContaIdBancoNavigations { get; set; }
        public virtual ICollection<RepresentantesConta> RepresentantesContaIdOutroBancoNavigations { get; set; }
        public virtual ICollection<TransportadorasConta> TransportadorasContaIdBancoNavigations { get; set; }
        public virtual ICollection<TransportadorasConta> TransportadorasContaIdOutroBancoNavigations { get; set; }
    }
}
