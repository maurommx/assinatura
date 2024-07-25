using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Fornecedore
    {
        public Fornecedore()
        {
            FornecedoresConta = new HashSet<FornecedoresConta>();
            FornecedoresContatos = new HashSet<FornecedoresContato>();
            NfCancelada = new HashSet<NfCancelada>();
            Ocorrencia = new HashSet<Ocorrencia>();
            Pagars = new HashSet<Pagar>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Orgao { get; set; }
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
        public string Telefone { get; set; }
        public string Telefone1 { get; set; }
        public string Fax { get; set; }
        public string Fax1 { get; set; }
        public string Contato { get; set; }
        public string Obs { get; set; }
        public string Site { get; set; }
        public string Email { get; set; }
        public string ContatoTipo { get; set; }
        public string ContatoId { get; set; }
        public int? IdTransportadora { get; set; }
        public bool? Correspondencia { get; set; }
        public string FreteTransportadora { get; set; }
        public string EnderecoCorrespondencia { get; set; }
        public string BairroCorrespondencia { get; set; }
        public string CidadeCorrespondencia { get; set; }
        public string UfCorrespondencia { get; set; }
        public string TelefoneCorrespondencia { get; set; }
        public int? NumeroCorrespondencia { get; set; }
        public string CepCorrespondencia { get; set; }
        public string ComplementoCorrespondencia { get; set; }
        public string Motivo { get; set; }
        public bool? Bloqueado { get; set; }
        public DateTime? DataBloqueio { get; set; }
        public string ContaContabil { get; set; }
        public string EmailNfe { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<FornecedoresConta> FornecedoresConta { get; set; }
        public virtual ICollection<FornecedoresContato> FornecedoresContatos { get; set; }
        public virtual ICollection<NfCancelada> NfCancelada { get; set; }
        public virtual ICollection<Ocorrencia> Ocorrencia { get; set; }
        public virtual ICollection<Pagar> Pagars { get; set; }
    }
}
