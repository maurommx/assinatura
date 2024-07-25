using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Transportadora
    {
        public Transportadora()
        {
            InverseIdTransportadoraNavigation = new HashSet<Transportadora>();
            TransportadorasConta = new HashSet<TransportadorasConta>();
            TransportadorasContatos = new HashSet<TransportadorasContato>();
            TransportadorasRegios = new HashSet<TransportadorasRegio>();
            VendasPedidosFechados = new HashSet<VendasPedidosFechado>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Ie { get; set; }
        public string Cgc { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Orgao { get; set; }
        public string Telefone { get; set; }
        public string Telefone1 { get; set; }
        public string Fax { get; set; }
        public bool? Redespacho { get; set; }
        public bool? Entrega { get; set; }
        public bool? Coleta { get; set; }
        public string ContaContabil { get; set; }
        public bool? Bloqueado { get; set; }
        public string Motivo { get; set; }
        public DateTime? DataBloqueio { get; set; }
        public int? IdTransportadora { get; set; }
        public string ContatoTipo { get; set; }
        public string ContatoId { get; set; }
        public string Email { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string EmailNfe { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public string Placa { get; set; }
        public string PlacaUf { get; set; }
        public string EmailNfe2 { get; set; }

        public virtual Transportadora IdTransportadoraNavigation { get; set; }
        public virtual ICollection<Transportadora> InverseIdTransportadoraNavigation { get; set; }
        public virtual ICollection<TransportadorasConta> TransportadorasConta { get; set; }
        public virtual ICollection<TransportadorasContato> TransportadorasContatos { get; set; }
        public virtual ICollection<TransportadorasRegio> TransportadorasRegios { get; set; }
        public virtual ICollection<VendasPedidosFechado> VendasPedidosFechados { get; set; }
    }
}
