using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities {
    [Table("Usuarios")]
    public class UsuarioEntity : BaseEntity {
        //[Required]
        //[MaxLength(30)]
        //public string Name { get; set; }
        //[Required]
        //[MaxLength(100)]
        //public string Email { get; set; }


        #region ChavesEstrangeiras
        public int? IdFuncionario { get; set; }
        #endregion

        #region Colunas
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime? Ulogin { get; set; }
        public bool? Expirou { get; set; }
        public bool? Administrador { get; set; }
        public bool? Funcionarios { get; set; }
        public bool? Compras { get; set; }
        public bool? Vendas { get; set; }
        public bool? Financeiro { get; set; }
        public bool? Ocorrencias { get; set; }
        #endregion

        #region MenuAcesso
        public bool? MnuCores { get; set; }
        public bool? MnuDivisoes { get; set; }
        public bool? MnuDivisoesCores { get; set; }
        public bool? MnuTransportadoras { get; set; }
        public bool? MnuFornecedores { get; set; }
        public bool? MnuFornecedoresContatos { get; set; }
        public bool? MnuPessoasFisicas { get; set; }
        public bool? MnuSetores { get; set; }
        public bool? MnuDepartamentos { get; set; }
        public bool? MnuRequisitantes { get; set; }
        public bool? MnuUnidades { get; set; }
        public bool? MnuRepresentantes { get; set; }
        public bool? MnuClientes { get; set; }
        public bool? MnuClientesContas { get; set; }
        public bool? MnuClientesResponsaveis { get; set; }
        public bool? MnuProdutos { get; set; }
        public bool? MnuInsumos { get; set; }
        public bool? MnuFuncionarios { get; set; }
        public bool? MnuPedidosInsumos { get; set; }
        public bool? MnuPedidosCompras { get; set; }
        public bool? MnuPedidos { get; set; }
        public bool? MnuEntradaInsumos { get; set; }
        public bool? MnuContas { get; set; }
        public bool? MnuTiposContatos { get; set; }
        public bool? MnuAssociacoes { get; set; }
        public bool? MnuRamos { get; set; }
        public bool? MnuDespesas { get; set; }
        public bool? MnuDespesasGrupos { get; set; }
        public bool? MnuFabricas { get; set; }
        public bool? MnuTabelaPreco { get; set; }
        public bool? MnuTabelaPrecoProdutos { get; set; }
        public bool? MnuTransportadorasRegioes { get; set; }
        public bool? MnuRepresentantesRegioes { get; set; }
        public bool? MnuBancos { get; set; }
        public bool? MnuBancosRegioes { get; set; }
        public bool? MnuClientesAssociados { get; set; }
        public bool? MnuTransportadorasContatos { get; set; }
        public bool? MnuConfiguracoes { get; set; }
        public bool? MnuMotivos { get; set; }
        public bool? MnuFornecedoresContas { get; set; }
        public bool? MnuRepresentantesContas { get; set; }
        public bool? MnuTransportadorasContas { get; set; }
        public bool? MnuClassificacaoFiscal { get; set; }
        public bool? MnuStatus { get; set; }
        public bool? MnuRepresentantesContatos { get; set; }
        public bool? MnuSenhaRepresentantes { get; set; }
        public bool? MnuPedidosFechados { get; set; }
        public bool? MnuCfop { get; set; }
        public bool? MnuCfopItens { get; set; }
        public bool? MnuCancelarNf { get; set; }
        public bool? MnuSacado { get; set; }
        public bool? MnuPagar { get; set; }
        public bool? MnuGerarArquivoRemessa { get; set; }
        public bool? MnuReimprimirNf { get; set; }
        public bool? MnuArquivoRetorno { get; set; }
        public bool? MnuReceber { get; set; }
        public bool? MnuNfManual { get; set; }
        public bool? MnuMateriaisGrupos { get; set; }
        public bool? MnuMateriaisTipos { get; set; }
        public bool? MnuEtiquetasAvulsas { get; set; }
        public bool? MnuCancelarArquivoRemessa { get; set; }
        public bool? MnuSintegra { get; set; }
        public bool? MnuNfEntrada { get; set; }
        public bool? MnuRelCores { get; set; }
        public bool? MnuRelPedidos { get; set; }
        public bool? MnuOrcamento { get; set; }
        public bool? MnuRelCobranca { get; set; }
        public bool? MnuRelPagamentos { get; set; }
        public bool? MnuRelFluxoCaixa { get; set; }
        public bool? MnuRelContas { get; set; }
        public bool? MnuRelCores1 { get; set; }
        public bool? MnuRelPedidosFechados { get; set; }
        public bool? MnuImprimirEtiquetas { get; set; }
        public bool? MnuRelVendas { get; set; }
        public bool? MnuRelPedidos1 { get; set; }
        public bool? MnuRelPedidosNovos { get; set; }
        public bool? MnuRelProdutos { get; set; }
        public bool? MnuServidores { get; set; }
        public bool? MnuSenhaRepresentante { get; set; }
        public bool? MnuLancamentos { get; set; }
        public bool? MnuUsuarios { get; set; }
        public bool? MnuClientesProdutosDesconto { get; set; }
        public bool? MnuRepresentantesProdutosDescontos { get; set; }
        public bool? MnuSenhaRepresentante1 { get; set; }
        public bool? MnuPedidosFechadosFaturar { get; set; }
        public bool? MnuRelCoresKilo { get; set; }
        public bool? MnuTransferencias { get; set; }
        public bool? MnuRelTransferencias { get; set; }
        public bool? MnuRelEmbarque { get; set; }
        public bool? MnuCidades { get; set; }
        public bool? MnuNfe { get; set; }
        public bool? MnuRelFaturamento { get; set; }
        public bool? MnuExcPedRej { get; set; }
        public bool? MnuGerarPdf { get; set; }
        public bool? MnuRegistrarProducao { get; set; }
        public bool? MnuRelProducao { get; set; }
        public bool? MnuRelGerencialVendas { get; set; }
        public bool? MnuEmailComercial { get; set; }
        public bool? MnuEmailFinanceiro { get; set; }
        public bool? MnuEmailNfe { get; set; }
        public bool? MnuAltTitulo { get; set; }
        public bool? MnuEmailPedidos { get; set; }
        public bool? MnuEmailPedidosVista { get; set; }
        public bool? MnuRelRankingVendas { get; set; }
        public bool? MnuRelMetasVenda { get; set; }
        public bool? MnuEtiquetasCartelas { get; set; }
        public bool? MnuConferente { get; set; }
        public bool? MnuRelGerencialdeProducao { get; set; }
        public bool? MnuRelListagemFioTinto { get; set; }
        public bool? MnuRelListagemProdutoAcabado { get; set; }
        public bool? MnuProgramacaoMaquinas { get; set; }
        public bool? MnuEstoqueFioTinto { get; set; }
        public bool? MnuEstoqueProdutoAcabado { get; set; }
        public bool? MnuImprimirCodigoBarras { get; set; }
        public bool? MnuLotes { get; set; }
        public bool? MnuFichaPlacaPedidoFechado { get; set; }
        public bool? MnuFichaAmostraTingimento { get; set; }
        public bool? MnuFichaBalancoFioTinto { get; set; }
        public bool? MnuFichaBalancoProdutoAcabado { get; set; }
        public bool? MnuFichaControleEpi { get; set; }
        public bool? MnuFichaPerdas { get; set; }
        public bool? MnuFichaFaltas { get; set; }
        public bool? MnuFichaPrateleiraProdAcab { get; set; }
        public bool? MnuFichaConicaleiraLongo { get; set; }
        public bool? MnuFichaViconeirasTubeteiras { get; set; }
        public bool? MnuFichaUniformes { get; set; }
        public bool? MnuEmbalador { get; set; }
        public bool? MnuPedidosFechadosProducao { get; set; }
        public bool? MnuRelPrevisaoProdutosProducao { get; set; }
        public bool? MnuRelProducaoMaquinas { get; set; }
        public bool? MnuRelProdutosProducao { get; set; }
        public bool? MnuRelProgramacaoLotes { get; set; }
        public bool? MnuRelTinturaria { get; set; }
        public bool? MnuRelProducaoTinturaria { get; set; }
        public bool? MnuRelCoresAutoclaves { get; set; }
        public bool? MnuLotesReprova { get; set; }
        public bool? MnuLotesAprova { get; set; }
        public bool? MnuImprimirLotes { get; set; }
        public bool? MnuSolicitarMaterial { get; set; }
        public bool? MnuProgramasTingimento { get; set; }
        public bool? MnuReceitas { get; set; }
        public bool? MnuTinturaria { get; set; }
        public bool? MnuAutoclaves { get; set; }
        public bool? MnuAutoclavesCapacidades { get; set; }
        public bool? MnuAutoclavesCores { get; set; }
        public bool? MnuSolicitacaoMaterial { get; set; }
        public bool? MnuMaquinas { get; set; }
        public bool? MnuImprimirCheques { get; set; }
        public bool? MnuRelCustoReceitas { get; set; }
        public bool? MnuRelEntregaCartelas { get; set; }
        public bool? MnuMovimentacaoFioTinto { get; set; }
        public bool? MnuFci { get; set; }
        public bool? MnuRelCoresFaturadas { get; set; }
        public bool? MnuProgramacaoMaquinasProdutos { get; set; }
        public bool? MnuRelVendaAnual { get; set; }
        public bool? MnuOcorrenciaMaquinas { get; set; }
        public bool? MnuSelecao { get; set; }
        public bool? MnuOcorrenciaMaquinas2 { get; set; }
        public bool? MnuRelInventarioEstoque { get; set; }
        public bool? MnuLotesTintos { get; set; }
        public bool? MnuProgramacaoFioTinto { get; set; }
        public bool? MnuCustoProducao { get; set; }
        public bool? MnuProdutoAcabadoAjuste { get; set; }
        public bool? MnuRelFaltas { get; set; }
        public bool? MnuFaltas { get; set; }
        public bool? MnuRelFioTinto { get; set; }
        public bool? MnuRelProdutoAcabado { get; set; }
        public bool? MnuCartelas { get; set; }
        public bool? MnuBlocoK { get; set; }
        public bool? MnuCatalogo { get; set; }
        public bool? MnuRelCustoLote { get; set; }
        public bool? MnuRelFluxoGerencial { get; set; }
        public bool? MnuBelcone { get; set; }
        public bool? MnuRelTransportadorasCidades { get; set; }
        public bool? MnuRelCte { get; set; }
        public bool? MnuTabelaPadrao { get; set; }
        public bool? MnuFichaRecrutamento { get; set; }
        public bool? MnuProcessarCte { get; set; }
        public bool? MnuAnaliseEstoques { get; set; }
        public bool? MnuRelEmbalador { get; set; }
        public bool? MnuRelComparativoProducao { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        #endregion

        #region Virtual
        public virtual FuncionarioEntity Funcionario { get; set; }
        #endregion
    }
}
