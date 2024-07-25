using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioEntity>
    {

        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            builder.ToTable("Usuarios");

            builder.Property(e => e.CreateAt).HasColumnType("datetime");

            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Expirou).HasDefaultValueSql("((0))");

            builder.Property(e => e.IdFuncionario).HasColumnName("Id_Funcionario");

            builder.Property(e => e.Login)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.MnuAltTitulo).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuAnaliseEstoques).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuAutoclaves).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuAutoclavesCapacidades)
                .HasColumnName("MnuAutoclaves_Capacidades")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuAutoclavesCores)
                .HasColumnName("MnuAutoclaves_Cores")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuBancosRegioes).HasColumnName("MnuBancos_Regioes");

            builder.Property(e => e.MnuBelcone).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuBlocoK).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuCancelarArquivoRemessa).HasColumnName("MnuCancelar_Arquivo_Remessa");

            builder.Property(e => e.MnuCancelarNf).HasColumnName("MnuCancelar_NF");

            builder.Property(e => e.MnuCartelas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuCatalogo).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuCfop).HasColumnName("MnuCFOP");

            builder.Property(e => e.MnuCfopItens).HasColumnName("MnuCFOP_Itens");

            builder.Property(e => e.MnuClientesAssociados).HasColumnName("MnuClientes_Associados");

            builder.Property(e => e.MnuClientesProdutosDesconto).HasColumnName("MnuClientes_Produtos_Desconto");

            builder.Property(e => e.MnuConferente).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuCustoProducao).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuDespesasGrupos).HasColumnName("MnuDespesas_Grupos");

            builder.Property(e => e.MnuEmailComercial).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuEmailFinanceiro).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuEmailNfe)
                .HasColumnName("MnuEmailNFe")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuEmailPedidos).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuEmailPedidosVista).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuEmbalador).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuEntradaInsumos).HasColumnName("MnuEntrada_Insumos");

            builder.Property(e => e.MnuEstoqueFioTinto)
                .HasColumnName("MnuEstoque_Fio_Tinto")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuEstoqueProdutoAcabado)
                .HasColumnName("MnuEstoque_Produto_Acabado")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuEtiquetasAvulsas).HasColumnName("MnuEtiquetas_Avulsas");

            builder.Property(e => e.MnuEtiquetasCartelas)
                .HasColumnName("MnuEtiquetas_Cartelas")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuExcPedRej)
                .HasColumnName("MnuExc_Ped_Rej")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFaltas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFci)
                .HasColumnName("MnuFCI")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaAmostraTingimento).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaBalancoFioTinto).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaBalancoProdutoAcabado).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaConicaleiraLongo).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaControleEpi)
                .HasColumnName("MnuFichaControleEPI")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaFaltas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaPerdas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaPlacaPedidoFechado)
                .HasColumnName("MnuFichaPlaca_Pedido_Fechado")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaPrateleiraProdAcab).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaRecrutamento).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaUniformes).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuFichaViconeirasTubeteiras).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuGerarArquivoRemessa).HasColumnName("MnuGerar_Arquivo_Remessa");

            builder.Property(e => e.MnuGerarPdf)
                .HasColumnName("MnuGerarPDF")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuImprimirCheques)
                .HasColumnName("MnuImprimir_Cheques")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuImprimirCodigoBarras)
                .HasColumnName("MnuImprimir_Codigo_Barras")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuImprimirEtiquetas).HasColumnName("MnuImprimir_Etiquetas");

            builder.Property(e => e.MnuImprimirLotes)
                .HasColumnName("MnuImprimir_Lotes")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuLotes).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuLotesAprova).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuLotesReprova).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuLotesTintos)
                .HasColumnName("MnuLotes_Tintos")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuMaquinas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuMateriaisGrupos).HasColumnName("MnuMateriais_Grupos");

            builder.Property(e => e.MnuMateriaisTipos).HasColumnName("MnuMateriais_Tipos");

            builder.Property(e => e.MnuMovimentacaoFioTinto)
                .HasColumnName("MnuMovimentacao_Fio_Tinto")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuNfEntrada).HasColumnName("MnuNF_Entrada");

            builder.Property(e => e.MnuNfManual).HasColumnName("Mnu_NF_Manual");

            builder.Property(e => e.MnuNfe).HasColumnName("MnuNFe");

            builder.Property(e => e.MnuOcorrenciaMaquinas)
                .HasColumnName("MnuOcorrencia_Maquinas")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuOcorrenciaMaquinas2)
                .HasColumnName("MnuOcorrencia_Maquinas2")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuPagar).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuPedidosCompras).HasColumnName("MnuPedidos_Compras");

            builder.Property(e => e.MnuPedidosFechados).HasColumnName("MnuPedidos_Fechados");

            builder.Property(e => e.MnuPedidosFechadosFaturar).HasColumnName("MnuPedidos_Fechados_Faturar");

            builder.Property(e => e.MnuPedidosFechadosProducao)
                .HasColumnName("MnuPedidos_Fechados_Producao")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuPedidosInsumos).HasColumnName("MnuPedidos_Insumos");

            builder.Property(e => e.MnuProcessarCte)
                .HasColumnName("MnuProcessarCTe")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuProdutoAcabadoAjuste).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuProgramacaoFioTinto).HasColumnName("MnuProgramacao_Fio_Tinto");

            builder.Property(e => e.MnuProgramacaoMaquinas)
                .HasColumnName("MnuProgramacao_Maquinas")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuProgramacaoMaquinasProdutos)
                .HasColumnName("MnuProgramacao_Maquinas_Produtos")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuProgramasTingimento)
                .HasColumnName("MnuProgramas_Tingimento")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuReceitas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuReimprimirNf).HasColumnName("MnuReimprimirNF");

            builder.Property(e => e.MnuRelComparativoProducao).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelCores).HasColumnName("MnuRel_Cores");

            builder.Property(e => e.MnuRelCores1).HasColumnName("MnuRelCores");

            builder.Property(e => e.MnuRelCoresAutoclaves)
                .HasColumnName("MnuRelCores_Autoclaves")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelCoresFaturadas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelCte)
                .HasColumnName("MnuRelCTe")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelCustoLote).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelCustoReceitas)
                .HasColumnName("MnuRelCusto_Receitas")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelEmbalador).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelEntregaCartelas)
                .HasColumnName("MnuRelEntrega_Cartelas")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelFaltas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelFioTinto).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelFluxoCaixa).HasColumnName("MnuRelFluxo_Caixa");

            builder.Property(e => e.MnuRelFluxoGerencial).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelGerencialVendas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelGerencialdeProducao).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelInventarioEstoque).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelListagemFioTinto).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelListagemProdutoAcabado).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelMetasVenda).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelPedidos).HasColumnName("MnuRel_Pedidos");

            builder.Property(e => e.MnuRelPedidos1).HasColumnName("MnuRelPedidos");

            builder.Property(e => e.MnuRelPedidosFechados).HasColumnName("MnuRelPedidos_Fechados");

            builder.Property(e => e.MnuRelPrevisaoProdutosProducao)
                .HasColumnName("MnuRelPrevisao_Produtos_Producao")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelProducaoMaquinas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelProducaoTinturaria)
                .HasColumnName("MnuRelProducao_Tinturaria")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelProdutoAcabado).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelProdutosProducao)
                .HasColumnName("MnuRelProdutos_Producao")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelProgramacaoLotes).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelRankingVendas).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelTinturaria).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelTransportadorasCidades)
                .HasColumnName("MnuRelTransportadoras_Cidades")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRelVendaAnual).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuRepresentantesProdutosDescontos).HasColumnName("MnuRepresentantes_Produtos_Descontos");

            builder.Property(e => e.MnuRepresentantesRegioes).HasColumnName("MnuRepresentantes_Regioes");

            builder.Property(e => e.MnuSelecao).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuSenhaRepresentante1).HasColumnName("MnuSenha_Representante");

            builder.Property(e => e.MnuSenhaRepresentantes).HasColumnName("MnuSenha_Representantes");

            builder.Property(e => e.MnuSolicitacaoMaterial)
                .HasColumnName("MnuSolicitacao_Material")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuSolicitarMaterial)
                .HasColumnName("MnuSolicitar_Material")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuTabelaPadrao).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuTabelaPreco).HasColumnName("MnuTabela_Preco");

            builder.Property(e => e.MnuTabelaPrecoProdutos).HasColumnName("MnuTabela_Preco_Produtos");

            builder.Property(e => e.MnuTinturaria).HasDefaultValueSql("((0))");

            builder.Property(e => e.MnuTiposContatos).HasColumnName("MnuTipos_Contatos");

            builder.Property(e => e.MnuTransportadorasContatos).HasColumnName("MnuTransportadoras_Contatos");

            builder.Property(e => e.MnuTransportadorasRegioes).HasColumnName("MnuTransportadoras_Regioes");

            builder.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Senha)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Ulogin)
                .HasColumnType("datetime")
                .HasColumnName("ULogin");

            builder.Property(e => e.UpdateAt).HasColumnType("datetime");

            builder.HasOne(d => d.Funcionario)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdFuncionario)
                .HasConstraintName("FK_Usuarios_Funcionarios");

        }
    }
}
