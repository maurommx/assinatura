using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Configuraco
    {
        public int Id { get; set; }
        public int? TimeOut { get; set; }
        public int? TimeOutOcorrencia { get; set; }
        public decimal? ParcelaMinima { get; set; }
        public double? PrecoMaximo { get; set; }
        public double? PrecoMinimo { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Uf { get; set; }
        public string CodUf { get; set; }
        public string Cidade { get; set; }
        public string CodCidade { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string ContaPagamento { get; set; }
        public int? Nf { get; set; }
        public int? NfHomologacao { get; set; }
        public string Pais { get; set; }
        public string CodPais { get; set; }
        public int? PeriodoFiltroMes { get; set; }
        public int? IdConta { get; set; }
        public int? Algarismos { get; set; }
        public int? MinSenha { get; set; }
        public bool? ForceUpper { get; set; }
        public bool? ForceLower { get; set; }
        public bool? ForceNum { get; set; }
        public string ContatoNfe { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public int? MetasVendas { get; set; }
        public decimal? ValorFrete { get; set; }
        public DateTime? VeraoInicio { get; set; }
        public DateTime? VeraoFim { get; set; }
        public string Fuso { get; set; }
        public DateTime? DataFechamento { get; set; }
        public string ServidorEmail { get; set; }
        public string EmailComercial { get; set; }
        public string EmailFinanceiro { get; set; }
        public string NomeFantasia { get; set; }
        public string ProdutosProgramacao { get; set; }
        public decimal? AliqPis { get; set; }
        public decimal? AliqCofins { get; set; }
        public int? SemanasFioTinto { get; set; }
        public int? SemanasLimiteFioTinto { get; set; }
        public int? MesesFioTinto { get; set; }
        public int? MesesCoresFaturadas { get; set; }
        public int? SemanasProdutoAcabado { get; set; }
        public int? SemanasLimiteProdutoAcabado { get; set; }
        public int? MesesProdutoAcabado { get; set; }
        public int? SemanasFioTintoProdAcab { get; set; }
        public int? DiasImprimirOp { get; set; }
        public int? IdTurno1 { get; set; }
        public int? IdTurno2 { get; set; }
        public int? IdTurno3 { get; set; }
        public int? IdTurno1Sabado { get; set; }
        public int? IdTurno2Sabado { get; set; }
        public int? IdTurno3Sabado { get; set; }
        public int? SaldoTeste { get; set; }
        public decimal? MargemLoteAprovado { get; set; }
        public bool? CapacidadeMaximaConicaleiras { get; set; }
        public bool? NfeProducao { get; set; }
        public string NfeGrupo { get; set; }
        public string NfeUsuario { get; set; }
        public string NfeSenha { get; set; }
        public string NfeUrl { get; set; }
        public string NfeSerie { get; set; }
        public int? IdContaPagamento { get; set; }
        public decimal? CotacaoUs { get; set; }
        public string UfEmbarque { get; set; }
        public string LocalEmbarque { get; set; }
        public string EmailRetorno { get; set; }
        public string LotesTinturaria { get; set; }
        public int? DiasLimiteProgramacao { get; set; }
        public decimal? FciReducaoEntrada { get; set; }
        public string StatusExcluidosLotes { get; set; }
        public int? IdTransportadora { get; set; }
        public DateTime? PrevisaoSaida { get; set; }
        public decimal? RecebidoClientes { get; set; }
        public int? DiasReprova { get; set; }
        public string ExcFioTinto { get; set; }
        public int? MinPreto44 { get; set; }
        public int? MinPreto133 { get; set; }
        public string NfeTokenNs { get; set; }
        public bool? ProibirReprocessoRicamare { get; set; }
        public int? IdTabelaPadrao { get; set; }
        public bool? LimiteSemanal { get; set; }
        public decimal? LimiteSemanalMargem { get; set; }
        public DateTime? PrevisaoSaidaPedido { get; set; }
        public string ProdutosProgramacaoPedidoFechado { get; set; }
        public decimal? AntecipadoAReceber { get; set; }
    }
}
