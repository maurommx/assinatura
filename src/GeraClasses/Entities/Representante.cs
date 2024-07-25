using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Representante
    {
        public Representante()
        {
            RepresentantesConta = new HashSet<RepresentantesConta>();
            RepresentantesContatos = new HashSet<RepresentantesContato>();
            RepresentantesProdutosDescontos = new HashSet<RepresentantesProdutosDesconto>();
            RepresentantesRegios = new HashSet<RepresentantesRegio>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Cnpj { get; set; }
        public string Orgao { get; set; }
        public string Ie { get; set; }
        public string Rg { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public int? Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Telefone1 { get; set; }
        public string Celular { get; set; }
        public string Celular1 { get; set; }
        public string Fax { get; set; }
        public string Cpf { get; set; }
        public string Ci { get; set; }
        public string MatriculaInss { get; set; }
        public string InssCidade { get; set; }
        public string CrrpEstado { get; set; }
        public string CrrpNumero { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public int? IdSetor { get; set; }
        public decimal? SalarioBase { get; set; }
        public bool? RecolheInss { get; set; }
        public string Apelido { get; set; }
        public bool? Status { get; set; }
        public string Email { get; set; }
        public int? IdTabelaPreco { get; set; }
        public double? DescontoTabelaPreco { get; set; }
        public int? IdFabrica { get; set; }
        public double? DescontoFabrica { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public bool? Bloqueado { get; set; }
        public string Motivo { get; set; }
        public string ContatoTipo { get; set; }
        public string ContatoId { get; set; }
        public DateTime? DataBloqueio { get; set; }
        public bool? LimiteFaturado { get; set; }
        public int? DiasFaturamento { get; set; }
        public bool? MetasVenda { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public string Core { get; set; }
        public bool? Entrega { get; set; }
        public string EnderecoEntrega { get; set; }
        public string BairroEntrega { get; set; }
        public string CidadeEntrega { get; set; }
        public string CodIbgeEntrega { get; set; }
        public string UfEntrega { get; set; }
        public string CodUfEntrega { get; set; }
        public int? NumeroEntrega { get; set; }
        public string CepEntrega { get; set; }
        public string ComplementoEntrega { get; set; }
        public string TelefoneEntrega { get; set; }

        public virtual TabelaPreco IdTabelaPrecoNavigation { get; set; }
        public virtual ICollection<RepresentantesConta> RepresentantesConta { get; set; }
        public virtual ICollection<RepresentantesContato> RepresentantesContatos { get; set; }
        public virtual ICollection<RepresentantesProdutosDesconto> RepresentantesProdutosDescontos { get; set; }
        public virtual ICollection<RepresentantesRegio> RepresentantesRegios { get; set; }
    }
}
