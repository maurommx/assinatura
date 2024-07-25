using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClientesAssociadoIdClienteAssociadoNavigations = new HashSet<ClientesAssociado>();
            ClientesAssociadoIdClienteNavigations = new HashSet<ClientesAssociado>();
            ClientesConta = new HashSet<ClientesConta>();
            ClientesProdutosDescontos = new HashSet<ClientesProdutosDesconto>();
            ClientesResponsaveis = new HashSet<ClientesResponsavei>();
            ClientesUsuarios = new HashSet<ClientesUsuario>();
            Consumidores = new HashSet<Consumidore>();
            Ocorrencia = new HashSet<Ocorrencia>();
            Recebers = new HashSet<Receber>();
            VendasPedidosFechados = new HashSet<VendasPedidosFechado>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CodIbge { get; set; }
        public string Uf { get; set; }
        public string CodUf { get; set; }
        public string Cep { get; set; }
        public string Cpf { get; set; }
        public string Cgc { get; set; }
        public string Ie { get; set; }
        public string Im { get; set; }
        public string Rg { get; set; }
        public string Orgao { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Contato { get; set; }
        public DateTime? DataFundacao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int? IdRepresentante { get; set; }
        public string ReferenciaEntrega { get; set; }
        public string EnderecoEntrega { get; set; }
        public string BairroEntrega { get; set; }
        public string CidadeEntrega { get; set; }
        public string CodIbgeEntrega { get; set; }
        public string UfEntrega { get; set; }
        public string CodUfEntrega { get; set; }
        public string TelefoneEntrega { get; set; }
        public int? NumeroEntrega { get; set; }
        public string CepEntrega { get; set; }
        public string ComplementoEntrega { get; set; }
        public bool? Bloqueado { get; set; }
        public string EnderecoCobranca { get; set; }
        public string BairroCobranca { get; set; }
        public string CidadeCobranca { get; set; }
        public string CodIbgeCobranca { get; set; }
        public string UfCobranca { get; set; }
        public string CodUfCobranca { get; set; }
        public string CepCobranca { get; set; }
        public int? NumeroCobranca { get; set; }
        public string ComplementoCobranca { get; set; }
        public string TelefoneCobranca { get; set; }
        public string Historico { get; set; }
        public string Tipo { get; set; }
        public string Classificacao { get; set; }
        public int? IdTransportadora { get; set; }
        public int? IdTransportadoraRedespacho { get; set; }
        public bool? Redespacho { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string ContatoTipo { get; set; }
        public string ContatoId { get; set; }
        public string Responsavel { get; set; }
        public string CpfResponsavel { get; set; }
        public double? Participacao { get; set; }
        public decimal? CapitalSocial { get; set; }
        public DateTime? Fundacao { get; set; }
        public int? IdRamo { get; set; }
        public string Segmento { get; set; }
        public bool? Entrega { get; set; }
        public bool? Cobranca { get; set; }
        public string FreteTransportadora { get; set; }
        public string FreteRedespacho { get; set; }
        public int? IdTabelaPreco { get; set; }
        public double? DescontoTabelaPreco { get; set; }
        public string IdFabrica { get; set; }
        public double? DescontoFabrica { get; set; }
        public string Motivo { get; set; }
        public string ContaContabil { get; set; }
        public DateTime? DataBloqueio { get; set; }
        public int? FormaPagamento { get; set; }
        public decimal? Parcela1 { get; set; }
        public decimal? Parcela2 { get; set; }
        public decimal? Parcela3 { get; set; }
        public decimal? Parcela4 { get; set; }
        public decimal? Parcela5 { get; set; }
        public decimal? Parcela6 { get; set; }
        public bool? Liberado { get; set; }
        public string EmailNfe { get; set; }
        public string EmailFinanceiro { get; set; }
        public string EmailComercial { get; set; }
        public string EmailComercial2 { get; set; }
        public string ContatoFinanceiro { get; set; }
        public string ContatoComercial { get; set; }
        public string ContatoComercial2 { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public string Pais { get; set; }
        public string CodPais { get; set; }
        public bool? Exportacao { get; set; }
        public bool? BeneficioEstadual { get; set; }
        public string RedeSocial1 { get; set; }
        public string RedeSocial2 { get; set; }
        public string Site1 { get; set; }
        public string Site2 { get; set; }
        public string InformacoesFiscais { get; set; }

        public virtual ICollection<ClientesAssociado> ClientesAssociadoIdClienteAssociadoNavigations { get; set; }
        public virtual ICollection<ClientesAssociado> ClientesAssociadoIdClienteNavigations { get; set; }
        public virtual ICollection<ClientesConta> ClientesConta { get; set; }
        public virtual ICollection<ClientesProdutosDesconto> ClientesProdutosDescontos { get; set; }
        public virtual ICollection<ClientesResponsavei> ClientesResponsaveis { get; set; }
        public virtual ICollection<ClientesUsuario> ClientesUsuarios { get; set; }
        public virtual ICollection<Consumidore> Consumidores { get; set; }
        public virtual ICollection<Ocorrencia> Ocorrencia { get; set; }
        public virtual ICollection<Receber> Recebers { get; set; }
        public virtual ICollection<VendasPedidosFechado> VendasPedidosFechados { get; set; }
    }
}
