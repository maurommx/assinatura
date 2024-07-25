using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Domain.Entities
{
    public partial class PolycronContext : DbContext
    {
        public PolycronContext()
        {
        }

        public PolycronContext(DbContextOptions<PolycronContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bairro> Bairros { get; set; }
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<BancosRegio> BancosRegioes { get; set; }
        public virtual DbSet<Boleto> Boletos { get; set; }
        public virtual DbSet<Cfop> Cfops { get; set; }
        public virtual DbSet<CfopIten> CfopItens { get; set; }
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<ClassificacaoFiscal> ClassificacaoFiscals { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClientesAlteracaoTabelaPreco> ClientesAlteracaoTabelaPrecos { get; set; }
        public virtual DbSet<ClientesAssociado> ClientesAssociados { get; set; }
        public virtual DbSet<ClientesConta> ClientesContas { get; set; }
        public virtual DbSet<ClientesDocumento> ClientesDocumentos { get; set; }
        public virtual DbSet<ClientesProdutosDesconto> ClientesProdutosDescontos { get; set; }
        public virtual DbSet<ClientesResponsavei> ClientesResponsaveis { get; set; }
        public virtual DbSet<ClientesUsuario> ClientesUsuarios { get; set; }
        public virtual DbSet<Configuraco> Configuracoes { get; set; }
        public virtual DbSet<Consumidore> Consumidores { get; set; }
        public virtual DbSet<Conta> Contas { get; set; }
        public virtual DbSet<ContaCorrenteSaldo> ContaCorrenteSaldos { get; set; }
        public virtual DbSet<Core> Cores { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Despesa> Despesas { get; set; }
        public virtual DbSet<DespesasGrupo> DespesasGrupos { get; set; }
        public virtual DbSet<Diviso> Divisoes { get; set; }
        public virtual DbSet<DivisoesCore> DivisoesCores { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Etiqueta> Etiquetas { get; set; }
        public virtual DbSet<EtiquetasVolume> EtiquetasVolumes { get; set; }
        public virtual DbSet<Fabrica> Fabricas { get; set; }
        public virtual DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public virtual DbSet<FormaRecebimento> FormaRecebimentos { get; set; }
        public virtual DbSet<Fornecedore> Fornecedores { get; set; }
        public virtual DbSet<FornecedoresConta> FornecedoresContas { get; set; }
        public virtual DbSet<FornecedoresContato> FornecedoresContatos { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<FuncionariosFabrica> FuncionariosFabricas { get; set; }
        public virtual DbSet<ImpBoleto> ImpBoletos { get; set; }
        public virtual DbSet<ImpFatura> ImpFaturas { get; set; }
        public virtual DbSet<ImpNf> ImpNfs { get; set; }
        public virtual DbSet<Insumo> Insumos { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<InventarioIten> InventarioItens { get; set; }
        public virtual DbSet<Lancamento> Lancamentos { get; set; }
        public virtual DbSet<Logradouro> Logradouros { get; set; }
        public virtual DbSet<MateriaisGrupo> MateriaisGrupos { get; set; }
        public virtual DbSet<MateriaisTipo> MateriaisTipos { get; set; }
        public virtual DbSet<Motivo> Motivos { get; set; }
        public virtual DbSet<MotivosBanco> MotivosBancos { get; set; }
        public virtual DbSet<MotivosBancos1> MotivosBancos1s { get; set; }
        public virtual DbSet<Nf> Nfs { get; set; }
        public virtual DbSet<NfCancelada> NfCanceladas { get; set; }
        public virtual DbSet<NfCanceladasIten> NfCanceladasItens { get; set; }
        public virtual DbSet<NfCce> NfCces { get; set; }
        public virtual DbSet<NfEntradaIten> NfEntradaItens { get; set; }
        public virtual DbSet<NfEntradum> NfEntrada { get; set; }
        public virtual DbSet<NfInutilizacao> NfInutilizacaos { get; set; }
        public virtual DbSet<NfIten> NfItens { get; set; }
        public virtual DbSet<NfReferenciada> NfReferenciadas { get; set; }
        public virtual DbSet<Ocorrencia> Ocorrencias { get; set; }
        public virtual DbSet<OcorrenciasBanco> OcorrenciasBancos { get; set; }
        public virtual DbSet<OcorrenciasConsumidor> OcorrenciasConsumidors { get; set; }
        public virtual DbSet<OcorrenciasLote> OcorrenciasLotes { get; set; }
        public virtual DbSet<OcorrenciasMaquina> OcorrenciasMaquinas { get; set; }
        public virtual DbSet<OcorrenciasNf> OcorrenciasNfs { get; set; }
        public virtual DbSet<OcorrenciasPedidosFechado> OcorrenciasPedidosFechados { get; set; }
        public virtual DbSet<OcorrenciasTransportadora> OcorrenciasTransportadoras { get; set; }
        public virtual DbSet<Origem> Origems { get; set; }
        public virtual DbSet<Pagar> Pagars { get; set; }
        public virtual DbSet<Paise> Paises { get; set; }
        public virtual DbSet<Producao> Producaos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Ramo> Ramos { get; set; }
        public virtual DbSet<Receber> Recebers { get; set; }
        public virtual DbSet<Remessa> Remessas { get; set; }
        public virtual DbSet<Representante> Representantes { get; set; }
        public virtual DbSet<RepresentantesConta> RepresentantesContas { get; set; }
        public virtual DbSet<RepresentantesContato> RepresentantesContatos { get; set; }
        public virtual DbSet<RepresentantesProdutosDesconto> RepresentantesProdutosDescontos { get; set; }
        public virtual DbSet<RepresentantesRegio> RepresentantesRegioes { get; set; }
        public virtual DbSet<Retorno> Retornos { get; set; }
        public virtual DbSet<Saldo> Saldos { get; set; }
        public virtual DbSet<Setore> Setores { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<TabelaPreco> TabelaPrecos { get; set; }
        public virtual DbSet<TabelaPrecoProduto> TabelaPrecoProdutos { get; set; }
        public virtual DbSet<TipoAgendamento> TipoAgendamentos { get; set; }
        public virtual DbSet<Transferencia> Transferencias { get; set; }
        public virtual DbSet<Transportadora> Transportadoras { get; set; }
        public virtual DbSet<TransportadorasColetum> TransportadorasColeta { get; set; }
        public virtual DbSet<TransportadorasConta> TransportadorasContas { get; set; }
        public virtual DbSet<TransportadorasContato> TransportadorasContatos { get; set; }
        public virtual DbSet<TransportadorasRegio> TransportadorasRegioes { get; set; }
        public virtual DbSet<Unidade> Unidades { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<VendasPedido> VendasPedidos { get; set; }
        public virtual DbSet<VendasPedidosFechado> VendasPedidosFechados { get; set; }
        public virtual DbSet<VendasPedidosFechadosAlerta> VendasPedidosFechadosAlertas { get; set; }
        public virtual DbSet<VendasPedidosFechadosExtra> VendasPedidosFechadosExtras { get; set; }
        public virtual DbSet<VendasPedidosFechadosFabrica> VendasPedidosFechadosFabricas { get; set; }
        public virtual DbSet<VendasPedidosFechadosNovo> VendasPedidosFechadosNovos { get; set; }
        public virtual DbSet<VendasPedidosFechadosPedido> VendasPedidosFechadosPedidos { get; set; }
        public virtual DbSet<VendasPedidosFechadosPedidosIten> VendasPedidosFechadosPedidosItens { get; set; }
        public virtual DbSet<VendasPedidosIten> VendasPedidosItens { get; set; }
        public virtual DbSet<VwCep> VwCeps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=127.0.0.1, 2354;Initial Catalog=Poly;MultipleActiveResultSets=true;User ID=LoginWeb;Password=web");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Bairro>(entity =>
            {
                entity.Property(e => e.Abreviado)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.IdCidade).HasColumnName("Id_Cidade");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdCidadeNavigation)
                    .WithMany(p => p.Bairros)
                    .HasForeignKey(d => d.IdCidade)
                    .HasConstraintName("FK_Bairros_Cidades");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.Property(e => e.AnoX).HasColumnName("Ano_X");

                entity.Property(e => e.Boleto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContaContabil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Conta_Contabil");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DiaSeguinte)
                    .HasColumnName("Dia_Seguinte")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiaX).HasColumnName("Dia_X");

                entity.Property(e => e.ExtensoX).HasColumnName("Extenso_X");

                entity.Property(e => e.ExtensoY).HasColumnName("Extenso_Y");

                entity.Property(e => e.LocalX).HasColumnName("Local_X");

                entity.Property(e => e.LocalY).HasColumnName("Local_Y");

                entity.Property(e => e.MesX).HasColumnName("Mes_X");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NominalX).HasColumnName("Nominal_X");

                entity.Property(e => e.NominalY).HasColumnName("Nominal_Y");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Nosso_Numero");

                entity.Property(e => e.Sequencial)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ValorX).HasColumnName("Valor_X");

                entity.Property(e => e.ValorY).HasColumnName("Valor_Y");
            });

            modelBuilder.Entity<BancosRegio>(entity =>
            {
                entity.ToTable("Bancos_Regioes");

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.BancosRegios)
                    .HasForeignKey(d => d.IdBanco)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Bancos_Regioes_Bancos");
            });

            modelBuilder.Entity<Boleto>(entity =>
            {
                entity.ToTable("Boletos_");

                entity.Property(e => e.B001001)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("B_001_001")
                    .HasComment("Identificacao do Registro");

                entity.Property(e => e.B002006)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("B_002_006")
                    .HasComment("Agencia de Debito");

                entity.Property(e => e.B007007)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("B_007_007")
                    .HasComment("Digito da Agencia de Debito");

                entity.Property(e => e.B008012)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("B_008_012")
                    .HasComment("Razao da Conta Corrente");

                entity.Property(e => e.B013019)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("B_013_019")
                    .HasComment("Conta Corrente");

                entity.Property(e => e.B020020)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("B_020_020")
                    .HasComment("Digito da Conta Corrente");

                entity.Property(e => e.B021037)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("B_021_037")
                    .HasComment("Identificacao da Empresa Cedente no Banco");

                entity.Property(e => e.B038062)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("B_038_062")
                    .HasComment("Nº Controle do Participante");

                entity.Property(e => e.B063065)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("B_063_065")
                    .HasComment("Codigo do Banco a ser debitado na Camara de Compensacao");

                entity.Property(e => e.B066070)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("B_066_070")
                    .HasComment("Zeros");

                entity.Property(e => e.B071081)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("B_071_081")
                    .HasComment("Identificacao do Titulo no Banco");

                entity.Property(e => e.B082082)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("B_082_082")
                    .HasComment("Digito de Auto Conferencia do Nosso Numero");

                entity.Property(e => e.B083092)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("B_083_092")
                    .HasComment("Desconto Bonificacao por dia");

                entity.Property(e => e.B093093)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("B_093_093")
                    .HasComment("Condicao para Emissao da Papeleta de Cobranca");

                entity.Property(e => e.B094094)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("B_094_094")
                    .HasComment("Ident. se emite papeleta para Debito Automatico");

                entity.Property(e => e.B095104)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("B_095_104")
                    .HasComment("Identificacao da Operacao do Banco");

                entity.Property(e => e.B105105)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("B_105_105")
                    .HasComment("Idicador Rateio Credito");

                entity.Property(e => e.B106106)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("B_106_106")
                    .HasComment("Enderecamento para Aviso do Debito Automatico em conta Corrente");

                entity.Property(e => e.B107108)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("B_107_108")
                    .HasComment("Branco");

                entity.Property(e => e.B109110)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("B_109_110")
                    .HasComment("Identificacao Ocorrencia");

                entity.Property(e => e.B111120)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("B_111_120")
                    .HasComment("Nº do Documento");

                entity.Property(e => e.B121126)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("B_121_126")
                    .HasComment("Data do Vencimento do Titulo");

                entity.Property(e => e.B127139)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("B_127_139")
                    .HasComment("Valor do Titulo");

                entity.Property(e => e.B140142)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("B_140_142")
                    .HasComment("Banco Encarregado da Cobranca");

                entity.Property(e => e.B143147)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("B_143_147")
                    .HasComment("Agencia Depositaria");

                entity.Property(e => e.B148149)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("B_148_149")
                    .HasComment("Especie de Titulo");

                entity.Property(e => e.B150150)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("B_150_150")
                    .HasComment("Identificacao");

                entity.Property(e => e.B151156)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("B_151_156")
                    .HasComment("Data da emissao do Titulo");

                entity.Property(e => e.B157158)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("B_157_158")
                    .HasComment("1º Instrucao");

                entity.Property(e => e.B159160)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("B_159_160")
                    .HasComment("2º Instrucao");

                entity.Property(e => e.B161173)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("B_161_173")
                    .HasComment("Valor a ser cobrado por Dia de Atraso");

                entity.Property(e => e.B174179)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("B_174_179")
                    .HasComment("Data Limite P/Concessao de Desconto");

                entity.Property(e => e.B180192)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("B_180_192")
                    .HasComment("Valor do Desconto");

                entity.Property(e => e.B193205)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("B_193_205")
                    .HasComment("Valor do IOF");

                entity.Property(e => e.B206218)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("B_206_218")
                    .HasComment("Valor do Abatimento a ser concedido ou cancelado");

                entity.Property(e => e.B219220)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("B_219_220")
                    .HasComment("Identificacao do Tipo de Inscricao do Sacado");

                entity.Property(e => e.B221234)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("B_221_234")
                    .HasComment("Nº Inscricao do Sacado");

                entity.Property(e => e.B235274)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("B_235_274")
                    .HasComment("Nome do Sacado");

                entity.Property(e => e.B275314)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("B_275_314")
                    .HasComment("Endereco Completo");

                entity.Property(e => e.B315326)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("B_315_326")
                    .HasComment("1º Mensagem");

                entity.Property(e => e.B327331)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("B_327_331")
                    .HasComment("CEP");

                entity.Property(e => e.B332334)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("B_332_334")
                    .HasComment("Sufixo do CEP");

                entity.Property(e => e.B335394)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("B_335_394")
                    .HasComment("Sacador/Avalista ou 2º Mensagem");

                entity.Property(e => e.B395400)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("B_395_400")
                    .HasComment("Nº Sequencial do Registro");

                entity.Property(e => e.GeradoArquivo)
                    .HasColumnName("Gerado_Arquivo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdConta).HasColumnName("Id_Conta");

                entity.Property(e => e.IdNota).HasColumnName("Id_Nota");

                entity.Property(e => e.IdRemessa).HasColumnName("Id_Remessa");

                entity.Property(e => e.IdRemessaAnt).HasColumnName("Id_remessa_ant");

                entity.Property(e => e.Impresso).HasDefaultValueSql("(0)");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdContaNavigation)
                    .WithMany(p => p.Boletos)
                    .HasForeignKey(d => d.IdConta)
                    .HasConstraintName("FK_Boletos_Contas");

                entity.HasOne(d => d.IdNotaNavigation)
                    .WithMany(p => p.Boletos)
                    .HasForeignKey(d => d.IdNota)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Boletos_NF");

                entity.HasOne(d => d.IdRemessaNavigation)
                    .WithMany(p => p.Boletos)
                    .HasForeignKey(d => d.IdRemessa)
                    .HasConstraintName("FK_Boletos_Remessas");
            });

            modelBuilder.Entity<Cfop>(entity =>
            {
                entity.ToTable("CFOP");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Devolucao).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDest).HasColumnName("idDest");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<CfopIten>(entity =>
            {
                entity.ToTable("CFOP_Itens");

                entity.Property(e => e.AliqCofins).HasColumnName("Aliq_COFINS");

                entity.Property(e => e.AliqIcmsCnpj).HasColumnName("Aliq_ICMS_CNPJ");

                entity.Property(e => e.AliqIcmsCpf).HasColumnName("Aliq_ICMS_CPF");

                entity.Property(e => e.AliqIcmsFci)
                    .HasColumnType("money")
                    .HasColumnName("Aliq_ICMS_FCI");

                entity.Property(e => e.AliqIpi).HasColumnName("Aliq_IPI");

                entity.Property(e => e.AliqPis).HasColumnName("Aliq_PIS");

                entity.Property(e => e.CstCnpj)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CST_CNPJ");

                entity.Property(e => e.CstCofins)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CST_COFINS");

                entity.Property(e => e.CstCpf)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CST_CPF");

                entity.Property(e => e.CstFci)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CST_FCI");

                entity.Property(e => e.CstIpi)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CST_IPI");

                entity.Property(e => e.CstPis)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CST_PIS");

                entity.Property(e => e.IdCfop).HasColumnName("Id_CFOP");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Obs)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Preferencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.RedIcmsCnpj).HasColumnName("Red_ICMS_CNPJ");

                entity.Property(e => e.RedIcmsCpf).HasColumnName("Red_ICMS_CPF");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.HasOne(d => d.IdCfopNavigation)
                    .WithMany(p => p.CfopItens)
                    .HasForeignKey(d => d.IdCfop)
                    .HasConstraintName("FK_CFOP_Itens_CFOP");
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.CodIbge)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Cod_IBGE");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.DescricaoB)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Descricao_B")
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.IdEstado).HasColumnName("Id_Estado");

                entity.Property(e => e.LocNuSequencialSub).HasColumnName("LOC_NU_SEQUENCIAL_SUB");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Situacao).HasColumnName("SITUACAO");

                entity.Property(e => e.TipoLocalidade)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_LOCALIDADE");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Cidades)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Cidades_Estados");
            });

            modelBuilder.Entity<ClassificacaoFiscal>(entity =>
            {
                entity.ToTable("Classificacao_Fiscal");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Ipi).HasColumnName("IPI");

                entity.Property(e => e.Letra)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ncm)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("NCM");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Clientes")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "_dta_index_Clientes_9_936598625__K1_3");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BairroCobranca)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Bairro_Cobranca");

                entity.Property(e => e.BairroEntrega)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Bairro_Entrega");

                entity.Property(e => e.BeneficioEstadual).HasColumnName("Beneficio_Estadual");

                entity.Property(e => e.Bloqueado).HasDefaultValueSql("((0))");

                entity.Property(e => e.CapitalSocial)
                    .HasColumnType("money")
                    .HasColumnName("Capital_Social");

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.CepCobranca)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP_Cobranca");

                entity.Property(e => e.CepEntrega)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP_Entrega");

                entity.Property(e => e.Cgc)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CGC");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CidadeCobranca)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Cidade_Cobranca");

                entity.Property(e => e.CidadeEntrega)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Cidade_Entrega");

                entity.Property(e => e.Classificacao)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cobranca).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodIbge)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Cod_IBGE");

                entity.Property(e => e.CodIbgeCobranca)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Cod_IBGE_Cobranca");

                entity.Property(e => e.CodIbgeEntrega)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Cod_IBGE_Entrega");

                entity.Property(e => e.CodPais)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Pais")
                    .HasDefaultValueSql("((1058))");

                entity.Property(e => e.CodUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Cod_UF");

                entity.Property(e => e.CodUfCobranca)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Cod_UF_Cobranca");

                entity.Property(e => e.CodUfEntrega)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Cod_UF_Entrega");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComplementoCobranca)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Complemento_Cobranca");

                entity.Property(e => e.ComplementoEntrega)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Complemento_Entrega");

                entity.Property(e => e.ContaContabil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Conta_Contabil");

                entity.Property(e => e.Contato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContatoComercial)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Comercial");

                entity.Property(e => e.ContatoComercial2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Comercial2");

                entity.Property(e => e.ContatoFinanceiro)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Financeiro");

                entity.Property(e => e.ContatoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Id");

                entity.Property(e => e.ContatoTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Tipo");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.CpfResponsavel)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF_Responsavel");

                entity.Property(e => e.DataBloqueio)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Bloqueio");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Cadastro");

                entity.Property(e => e.DataFundacao)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Fundacao");

                entity.Property(e => e.DescontoFabrica).HasColumnName("Desconto_Fabrica");

                entity.Property(e => e.DescontoTabelaPreco).HasColumnName("Desconto_Tabela_Preco");

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EmailComercial)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EmailComercial2)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFinanceiro)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EmailNfe)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EmailNFe");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoCobranca)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Cobranca");

                entity.Property(e => e.EnderecoEntrega)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Entrega");

                entity.Property(e => e.Entrega).HasDefaultValueSql("((0))");

                entity.Property(e => e.Exportacao).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FormaPagamento).HasColumnName("Forma_Pagamento");

                entity.Property(e => e.FreteRedespacho)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FreteTransportadora)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fundacao).HasColumnType("datetime");

                entity.Property(e => e.Historico).HasColumnType("text");

                entity.Property(e => e.IdFabrica)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Id_Fabrica");

                entity.Property(e => e.IdRamo).HasColumnName("Id_Ramo");

                entity.Property(e => e.IdRepresentante).HasColumnName("Id_Representante");

                entity.Property(e => e.IdTabelaPreco).HasColumnName("Id_Tabela_Preco");

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.IdTransportadoraRedespacho).HasColumnName("Id_Transportadora_Redespacho");

                entity.Property(e => e.Ie)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IE");

                entity.Property(e => e.Im)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IM");

                entity.Property(e => e.InformacoesFiscais)
                    .HasColumnType("text")
                    .HasColumnName("Informacoes_Fiscais");

                entity.Property(e => e.Liberado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Fantasia");

                entity.Property(e => e.NumeroCobranca).HasColumnName("Numero_Cobranca");

                entity.Property(e => e.NumeroEntrega).HasColumnName("Numero_Entrega");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BRASIL')");

                entity.Property(e => e.Parcela1).HasColumnType("money");

                entity.Property(e => e.Parcela2).HasColumnType("money");

                entity.Property(e => e.Parcela3).HasColumnType("money");

                entity.Property(e => e.Parcela4).HasColumnType("money");

                entity.Property(e => e.Parcela5).HasColumnType("money");

                entity.Property(e => e.Parcela6).HasColumnType("money");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Razao_Social");

                entity.Property(e => e.RedeSocial1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Rede_Social1");

                entity.Property(e => e.RedeSocial2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Rede_Social2");

                entity.Property(e => e.Redespacho).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferenciaEntrega)
                    .HasColumnType("text")
                    .HasColumnName("Referencia_Entrega");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RG");

                entity.Property(e => e.Segmento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Site1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Site2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneCobranca)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Telefone_Cobranca");

                entity.Property(e => e.TelefoneEntrega)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Telefone_Entrega");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('J')");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.Property(e => e.UfCobranca)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF_Cobranca");

                entity.Property(e => e.UfEntrega)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF_Entrega");
            });

            modelBuilder.Entity<ClientesAlteracaoTabelaPreco>(entity =>
            {
                entity.ToTable("Clientes_Alteracao_Tabela_Preco");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdTabelaAnterior).HasColumnName("Id_Tabela_Anterior");

                entity.Property(e => e.IdTabelaAtual).HasColumnName("Id_Tabela_Atual");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientesAssociado>(entity =>
            {
                entity.ToTable("Clientes_Associados");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdClienteAssociado).HasColumnName("Id_Cliente_Associado");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientesAssociadoIdClienteNavigations)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Clientes_Associados_Clientes");

                entity.HasOne(d => d.IdClienteAssociadoNavigation)
                    .WithMany(p => p.ClientesAssociadoIdClienteAssociadoNavigations)
                    .HasForeignKey(d => d.IdClienteAssociado)
                    .HasConstraintName("FK_Clientes_Associados_Clientes1");
            });

            modelBuilder.Entity<ClientesConta>(entity =>
            {
                entity.ToTable("Clientes_Contas");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Conta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("Conta_Desde");

                entity.Property(e => e.DigitoAgencia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Digito_Agencia");

                entity.Property(e => e.DigitoConta)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Digito_Conta");

                entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdOutroBanco).HasColumnName("Id_Outro_Banco");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NomeAgencia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Agencia");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Titular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.ClientesConta)
                    .HasForeignKey(d => d.IdBanco)
                    .HasConstraintName("FK_Clientes_Contas_Bancos");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientesConta)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Clientes_Contas_Clientes");

                entity.HasOne(d => d.IdOutroBancoNavigation)
                    .WithMany(p => p.ClientesConta)
                    .HasForeignKey(d => d.IdOutroBanco)
                    .HasConstraintName("FK_Clientes_Contas_Bairros");
            });

            modelBuilder.Entity<ClientesDocumento>(entity =>
            {
                entity.ToTable("Clientes_Documentos");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Extensao)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.Obs).HasColumnType("text");
            });

            modelBuilder.Entity<ClientesProdutosDesconto>(entity =>
            {
                entity.ToTable("Clientes_Produtos_Desconto");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdProduto).HasColumnName("Id_Produto");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientesProdutosDescontos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Clientes_Produtos_Desconto_Clientes");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.ClientesProdutosDescontos)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_Clientes_Produtos_Desconto_Produtos");
            });

            modelBuilder.Entity<ClientesResponsavei>(entity =>
            {
                entity.ToTable("Clientes_Responsaveis");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Comunicacao)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ContatoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Id");

                entity.Property(e => e.ContatoTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Tipo");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ramal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientesResponsaveis)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clientes_Responsaveis_Clientes");
            });

            modelBuilder.Entity<ClientesUsuario>(entity =>
            {
                entity.ToTable("Clientes_Usuarios");

                entity.HasIndex(e => e.UserName, "IX_Clientes_Usuarios")
                    .IsUnique();

                entity.Property(e => e.Bloqueado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Expirou).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.MnuLevantamento).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuPedidos).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuUsuarios).HasDefaultValueSql("((0))");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("Ultimo_Login");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientesUsuarios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clientes_Usuarios_Clientes");
            });

            modelBuilder.Entity<Configuraco>(entity =>
            {
                entity.Property(e => e.AliqCofins)
                    .HasColumnType("money")
                    .HasColumnName("Aliq_COFINS");

                entity.Property(e => e.AliqPis)
                    .HasColumnType("money")
                    .HasColumnName("Aliq_PIS");

                entity.Property(e => e.AntecipadoAReceber)
                    .HasColumnType("money")
                    .HasColumnName("Antecipado_A_Receber");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadeMaximaConicaleiras)
                    .HasColumnName("Capacidade_Maxima_Conicaleiras")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.CodCidade)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Cidade");

                entity.Property(e => e.CodPais)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Pais");

                entity.Property(e => e.CodUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Cod_UF");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ContaPagamento)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Contato)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.ContatoNfe)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("ContatoNFe");

                entity.Property(e => e.CotacaoUs)
                    .HasColumnType("money")
                    .HasColumnName("Cotacao_US");

                entity.Property(e => e.DataFechamento)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Fechamento");

                entity.Property(e => e.DiasImprimirOp)
                    .HasColumnName("Dias_Imprimir_OP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiasLimiteProgramacao).HasColumnName("Dias_Limite_Programacao");

                entity.Property(e => e.DiasReprova).HasColumnName("Dias_Reprova");

                entity.Property(e => e.EmailComercial)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Email_Comercial");

                entity.Property(e => e.EmailFinanceiro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Email_Financeiro");

                entity.Property(e => e.EmailRetorno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Email_Retorno");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.ExcFioTinto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Exc_Fio_Tinto");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FciReducaoEntrada)
                    .HasColumnType("money")
                    .HasColumnName("FCI_Reducao_Entrada");

                entity.Property(e => e.ForceLower).HasColumnName("Force_Lower");

                entity.Property(e => e.ForceNum).HasColumnName("Force_Num");

                entity.Property(e => e.ForceUpper).HasColumnName("Force_Upper");

                entity.Property(e => e.Fuso)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdConta).HasColumnName("Id_Conta");

                entity.Property(e => e.IdContaPagamento).HasColumnName("Id_Conta_Pagamento");

                entity.Property(e => e.IdTabelaPadrao).HasColumnName("Id_Tabela_Padrao");

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.IdTurno1).HasColumnName("Id_Turno1");

                entity.Property(e => e.IdTurno1Sabado).HasColumnName("Id_Turno1_Sabado");

                entity.Property(e => e.IdTurno2).HasColumnName("Id_Turno2");

                entity.Property(e => e.IdTurno2Sabado).HasColumnName("Id_Turno2_Sabado");

                entity.Property(e => e.IdTurno3).HasColumnName("Id_Turno3");

                entity.Property(e => e.IdTurno3Sabado).HasColumnName("Id_Turno3_Sabado");

                entity.Property(e => e.Ie)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("IE");

                entity.Property(e => e.LimiteSemanal)
                    .HasColumnName("Limite_Semanal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LimiteSemanalMargem)
                    .HasColumnType("money")
                    .HasColumnName("Limite_Semanal_Margem");

                entity.Property(e => e.LocalEmbarque)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Local_Embarque");

                entity.Property(e => e.LotesTinturaria)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Lotes_Tinturaria");

                entity.Property(e => e.MargemLoteAprovado)
                    .HasColumnType("money")
                    .HasColumnName("Margem_Lote_Aprovado");

                entity.Property(e => e.MesesCoresFaturadas).HasColumnName("Meses_Cores_Faturadas");

                entity.Property(e => e.MesesFioTinto).HasColumnName("Meses_Fio_Tinto");

                entity.Property(e => e.MesesProdutoAcabado).HasColumnName("Meses_Produto_Acabado");

                entity.Property(e => e.MetasVendas).HasColumnName("Metas_Vendas");

                entity.Property(e => e.MinPreto133).HasColumnName("Min_Preto_133");

                entity.Property(e => e.MinPreto44).HasColumnName("Min_Preto_44");

                entity.Property(e => e.MinSenha).HasColumnName("Min_Senha");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Nf).HasColumnName("NF");

                entity.Property(e => e.NfHomologacao).HasColumnName("NF_Homologacao");

                entity.Property(e => e.NfeGrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NFe_Grupo");

                entity.Property(e => e.NfeProducao).HasColumnName("NFe_Producao");

                entity.Property(e => e.NfeSenha)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NFe_Senha");

                entity.Property(e => e.NfeSerie)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("NFe_Serie");

                entity.Property(e => e.NfeTokenNs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NFe_Token_NS");

                entity.Property(e => e.NfeUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NFe_URL");

                entity.Property(e => e.NfeUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NFe_Usuario");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Fantasia");

                entity.Property(e => e.Numero)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ParcelaMinima)
                    .HasColumnType("money")
                    .HasColumnName("Parcela_Minima");

                entity.Property(e => e.PeriodoFiltroMes).HasColumnName("Periodo_Filtro_Mes");

                entity.Property(e => e.PrecoMaximo).HasColumnName("Preco_Maximo");

                entity.Property(e => e.PrecoMinimo).HasColumnName("Preco_Minimo");

                entity.Property(e => e.PrevisaoSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("Previsao_Saida");

                entity.Property(e => e.PrevisaoSaidaPedido)
                    .HasColumnType("datetime")
                    .HasColumnName("Previsao_Saida_Pedido");

                entity.Property(e => e.ProdutosProgramacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Produtos_Programacao");

                entity.Property(e => e.ProdutosProgramacaoPedidoFechado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Produtos_Programacao_Pedido_Fechado");

                entity.Property(e => e.ProibirReprocessoRicamare)
                    .HasColumnName("Proibir_Reprocesso_Ricamare")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Razao_Social");

                entity.Property(e => e.RecebidoClientes)
                    .HasColumnType("money")
                    .HasColumnName("Recebido_Clientes");

                entity.Property(e => e.SaldoTeste).HasColumnName("Saldo_Teste");

                entity.Property(e => e.SemanasFioTinto).HasColumnName("Semanas_Fio_Tinto");

                entity.Property(e => e.SemanasFioTintoProdAcab).HasColumnName("Semanas_Fio_Tinto_Prod_Acab");

                entity.Property(e => e.SemanasLimiteFioTinto).HasColumnName("Semanas_Limite_Fio_Tinto");

                entity.Property(e => e.SemanasLimiteProdutoAcabado).HasColumnName("Semanas_Limite_Produto_Acabado");

                entity.Property(e => e.SemanasProdutoAcabado).HasColumnName("Semanas_Produto_Acabado");

                entity.Property(e => e.ServidorEmail)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Servidor_Email");

                entity.Property(e => e.StatusExcluidosLotes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Status_Excluidos_Lotes");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOutOcorrencia).HasColumnName("TimeOut_Ocorrencia");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.Property(e => e.UfEmbarque)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF_Embarque");

                entity.Property(e => e.ValorFrete)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Frete");

                entity.Property(e => e.VeraoFim)
                    .HasColumnType("datetime")
                    .HasColumnName("Verao_Fim");

                entity.Property(e => e.VeraoInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("Verao_Inicio");
            });

            modelBuilder.Entity<Consumidore>(entity =>
            {
                entity.HasIndex(e => e.Email, "IX_Consumidores")
                    .IsUnique();

                entity.Property(e => e.Bairro)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Bloqueado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Cadastro");

                entity.Property(e => e.DataFundacao)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Fundacao");

                entity.Property(e => e.Distribuidor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.Kron).HasDefaultValueSql("((0))");

                entity.Property(e => e.Liberado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Polycron).HasDefaultValueSql("((0))");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Razao_Social");

                entity.Property(e => e.Ricamare).HasDefaultValueSql("((0))");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.Property(e => e.Vip).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Consumidores)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Consumidores_Clientes");
            });

            modelBuilder.Entity<Conta>(entity =>
            {
                entity.Property(e => e.Agencia)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Bloqueado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Carteira)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEmpresa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Empresa");

                entity.Property(e => e.Complementar)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Conta1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Conta");

                entity.Property(e => e.ContaContabil)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ContaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("Conta_Desde");

                entity.Property(e => e.DiaSeguinte)
                    .HasColumnName("Dia_Seguinte")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DigitoAgencia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Digito_Agencia");

                entity.Property(e => e.DigitoConta)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Digito_Conta");

                entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");

                entity.Property(e => e.Investimento).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mensagem)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Multa).HasColumnType("money");

                entity.Property(e => e.NomeAgencia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Agencia");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Nosso_Numero");

                entity.Property(e => e.Pagamento).HasDefaultValueSql("((0))");

                entity.Property(e => e.Saldo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoAntecipado)
                    .HasColumnType("money")
                    .HasColumnName("Saldo_Antecipado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sequencial)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Titular)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Variacao)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.IdBanco)
                    .HasConstraintName("FK_Contas_Bancos");
            });

            modelBuilder.Entity<ContaCorrenteSaldo>(entity =>
            {
                entity.ToTable("Conta_Corrente_Saldo");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.IdConta).HasColumnName("Id_Conta");

                entity.Property(e => e.Saldo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdContaNavigation)
                    .WithMany(p => p.ContaCorrenteSaldos)
                    .HasForeignKey(d => d.IdConta)
                    .HasConstraintName("FK_Conta_Corrente_Saldo_Contas");
            });

            modelBuilder.Entity<Core>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Cores")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdSetor).HasColumnName("Id_Setor");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Despesa>(entity =>
            {
                entity.Property(e => e.ContaContabil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Conta_Contabil");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fio).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdGrupo).HasColumnName("Id_Grupo");

                entity.Property(e => e.IdHistoricoContabil).HasColumnName("Id_Historico_Contabil");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Despesas)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("FK_Despesas_Despesas_Grupos");
            });

            modelBuilder.Entity<DespesasGrupo>(entity =>
            {
                entity.ToTable("Despesas_Grupos");

                entity.HasIndex(e => e.Descricao, "IX_Despesas_Grupos")
                    .IsUnique();

                entity.Property(e => e.ContaContabil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Conta_Contabil");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartamento).HasColumnName("Id_Departamento");

                entity.Property(e => e.IdSetor).HasColumnName("Id_Setor");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.DespesasGrupos)
                    .HasForeignKey(d => d.IdDepartamento)
                    .HasConstraintName("FK_Despesas_Grupos_Departamentos");

                entity.HasOne(d => d.IdSetorNavigation)
                    .WithMany(p => p.DespesasGrupos)
                    .HasForeignKey(d => d.IdSetor)
                    .HasConstraintName("FK_Despesas_Grupos_Setores");
            });

            modelBuilder.Entity<Diviso>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Fabricas")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cota).HasColumnType("money");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<DivisoesCore>(entity =>
            {
                entity.ToTable("Divisoes_Cores");

                entity.Property(e => e.IdCor).HasColumnName("Id_Cor");

                entity.Property(e => e.IdDivisao).HasColumnName("Id_Divisao");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Tonalidade)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCorNavigation)
                    .WithMany(p => p.DivisoesCores)
                    .HasForeignKey(d => d.IdCor)
                    .HasConstraintName("FK_Fabrica_Cores_Cores");

                entity.HasOne(d => d.IdDivisaoNavigation)
                    .WithMany(p => p.DivisoesCores)
                    .HasForeignKey(d => d.IdDivisao)
                    .HasConstraintName("FK_Fabrica_Cores_Fabricas");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.CodigoIbge)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_IBGE")
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.ConsultaCnpj).HasColumnName("Consulta_CNPJ");

                entity.Property(e => e.ConsultaCpf).HasColumnName("Consulta_CPF");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(72)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.DiasEntrega).HasColumnName("Dias_Entrega");

                entity.Property(e => e.Frete).HasColumnType("money");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");
            });

            modelBuilder.Entity<Etiqueta>(entity =>
            {
                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdFornecedor).HasColumnName("Id_Fornecedor");

                entity.Property(e => e.IdRepresentante).HasColumnName("Id_Representante");

                entity.Property(e => e.Impresso).HasDefaultValueSql("((0))");

                entity.Property(e => e.Liberado).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.PortaImpressao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Porta_Impressao");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EtiquetasVolume>(entity =>
            {
                entity.ToTable("Etiquetas_Volumes");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.Impresso).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Nf)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NF");

                entity.Property(e => e.PortaImpressao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Porta_Impressao");

                entity.Property(e => e.Volume)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fabrica>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdDivisao).HasColumnName("Id_Divisao");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Resumido)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdDivisaoNavigation)
                    .WithMany(p => p.Fabricas)
                    .HasForeignKey(d => d.IdDivisao)
                    .HasConstraintName("FK_Fabricas_Divisoes");
            });

            modelBuilder.Entity<FormaPagamento>(entity =>
            {
                entity.ToTable("Forma_Pagamento");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<FormaRecebimento>(entity =>
            {
                entity.ToTable("Forma_Recebimento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Fornecedore>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Fornecedores");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BairroCorrespondencia)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Bairro_Correspondencia");

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CepCorrespondencia)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP_Correspondencia");

                entity.Property(e => e.Cgc)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CGC");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CidadeCorrespondencia)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Cidade_Correspondencia");

                entity.Property(e => e.CodIbge)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Cod_IBGE");

                entity.Property(e => e.CodUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Cod_UF");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComplementoCorrespondencia)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Complemento_Correspondencia");

                entity.Property(e => e.ContaContabil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Conta_Contabil");

                entity.Property(e => e.Contato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContatoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Id");

                entity.Property(e => e.ContatoTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Tipo");

                entity.Property(e => e.Correspondencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.DataBloqueio)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Bloqueio");

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EmailNfe)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EmailNFe");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoCorrespondencia)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Correspondencia");

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Fax1)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.FreteTransportadora)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.Ie)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IE");

                entity.Property(e => e.Im)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IM");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Fantasia");

                entity.Property(e => e.NumeroCorrespondencia).HasColumnName("Numero_Correspondencia");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Razao_Social");

                entity.Property(e => e.Rg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RG");

                entity.Property(e => e.Site)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone1)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneCorrespondencia)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Telefone_Correspondencia");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.Property(e => e.UfCorrespondencia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF_Correspondencia");
            });

            modelBuilder.Entity<FornecedoresConta>(entity =>
            {
                entity.ToTable("Fornecedores_Contas");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Conta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("Conta_Desde");

                entity.Property(e => e.DigitoAgencia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Digito_Agencia");

                entity.Property(e => e.DigitoConta)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Digito_Conta");

                entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");

                entity.Property(e => e.IdFornecedor).HasColumnName("Id_Fornecedor");

                entity.Property(e => e.IdOutroBanco).HasColumnName("Id_Outro_Banco");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NomeAgencia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Agencia");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Titular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.FornecedoresContaIdBancoNavigations)
                    .HasForeignKey(d => d.IdBanco)
                    .HasConstraintName("FK_Fornecedores_Contas_Bancos");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.FornecedoresConta)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("FK_Fornecedores_Contas_Fornecedores");

                entity.HasOne(d => d.IdOutroBancoNavigation)
                    .WithMany(p => p.FornecedoresContaIdOutroBancoNavigations)
                    .HasForeignKey(d => d.IdOutroBanco)
                    .HasConstraintName("FK_Fornecedores_Contas_Bancos1");
            });

            modelBuilder.Entity<FornecedoresContato>(entity =>
            {
                entity.ToTable("Fornecedores_Contatos");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ContatoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Id");

                entity.Property(e => e.ContatoTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Tipo");

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IdFornecedor).HasColumnName("Id_Fornecedor");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ramal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.FornecedoresContatos)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("FK_Fornecedores_Contatos_Fornecedores");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.Property(e => e.Bloqueado).HasDefaultValueSql("((0))");

                entity.Property(e => e.BtnAdicionar)
                    .HasColumnName("Btn_Adicionar")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BtnPedido)
                    .HasColumnName("Btn_Pedido")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BtnTotal)
                    .HasColumnName("Btn_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ContatoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Id");

                entity.Property(e => e.ContatoTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Tipo");

                entity.Property(e => e.Coordenadora).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EmailLote)
                    .HasColumnName("Email_Lote")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailMaquinas)
                    .HasColumnName("Email_Maquinas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailPedidoFechado)
                    .HasColumnName("Email_Pedido_Fechado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailPedidoRelVendas)
                    .HasColumnName("Email_Pedido_Rel_Vendas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDepartamento).HasColumnName("Id_Departamento");

                entity.Property(e => e.IdFuncionarioProducao).HasColumnName("Id_Funcionario_Producao");

                entity.Property(e => e.IdSetor).HasColumnName("Id_Setor");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ramal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Requisitante).HasDefaultValueSql("((0))");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.Property(e => e.Usuario).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.IdDepartamento)
                    .HasConstraintName("FK_Funcionarios_Departamentos");

                entity.HasOne(d => d.IdSetorNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.IdSetor)
                    .HasConstraintName("FK_Funcionarios_Setores1");
            });

            modelBuilder.Entity<FuncionariosFabrica>(entity =>
            {
                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.IdFabrica).HasColumnName("Id_Fabrica");

                entity.Property(e => e.IdFuncionario).HasColumnName("Id_Funcionario");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdFabricaNavigation)
                    .WithMany(p => p.FuncionariosFabricas)
                    .HasForeignKey(d => d.IdFabrica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FuncionariosFabricas_Fabrica");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.FuncionariosFabricas)
                    .HasForeignKey(d => d.IdFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FuncionariosFabricas_Funcionario");
            });

            modelBuilder.Entity<ImpBoleto>(entity =>
            {
                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdBoleto).HasColumnName("Id_Boleto");

                entity.Property(e => e.IdReceber).HasColumnName("Id_Receber");

                entity.Property(e => e.Impresso).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<ImpFatura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Imp_Faturas");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdNf).HasColumnName("Id_NF");
            });

            modelBuilder.Entity<ImpNf>(entity =>
            {
                entity.ToTable("ImpNF");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdNf).HasColumnName("Id_NF");

                entity.Property(e => e.Impresso).HasDefaultValueSql("(0)");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Insumo>(entity =>
            {
                entity.Property(e => e.Caracteristicas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Estoque)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Finalidade)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Gtin)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("GTIN");

                entity.Property(e => e.IdGrupo).HasColumnName("Id_Grupo");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.Property(e => e.IdUnidade).HasColumnName("Id_Unidade");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ncm)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("NCM");

                entity.Property(e => e.Preco).HasColumnType("money");

                entity.Property(e => e.PrecoAnterior)
                    .HasColumnType("money")
                    .HasColumnName("Preco_Anterior");

                entity.Property(e => e.QuantidadeEmbalado).HasColumnName("Quantidade_Embalado");

                entity.Property(e => e.QuantidadeEstoque).HasColumnName("Quantidade_Estoque");

                entity.Property(e => e.QuantidadeVolume).HasColumnName("Quantidade_Volume");

                entity.Property(e => e.UltimaCompra)
                    .HasColumnType("datetime")
                    .HasColumnName("Ultima_Compra");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Insumos)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("FK_Insumos_Materiais_Grupos");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Insumos)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK_Insumos_Materiais_Tipos");

                entity.HasOne(d => d.IdUnidadeNavigation)
                    .WithMany(p => p.Insumos)
                    .HasForeignKey(d => d.IdUnidade)
                    .HasConstraintName("FK_Insumos_Unidades");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.ToTable("Inventario");

                entity.Property(e => e.Data).HasColumnType("datetime");
            });

            modelBuilder.Entity<InventarioIten>(entity =>
            {
                entity.ToTable("Inventario_Itens");

                entity.Property(e => e.IdInventario).HasColumnName("Id_Inventario");

                entity.Property(e => e.IdProduto).HasColumnName("Id_Produto");

                entity.Property(e => e.Qtda).HasColumnType("money");

                entity.Property(e => e.Valor).HasColumnType("money");
            });

            modelBuilder.Entity<Lancamento>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Conta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContaContabil)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.IdSaldo).HasColumnName("id_Saldo");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.HasOne(d => d.IdSaldoNavigation)
                    .WithMany(p => p.Lancamentos)
                    .HasForeignKey(d => d.IdSaldo)
                    .HasConstraintName("FK_Lancamentos_Saldos");
            });

            modelBuilder.Entity<Logradouro>(entity =>
            {
                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.DescricaoNaoAbreviada)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DescricaoSemAcento)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.IdBairro).HasColumnName("Id_Bairro");

                entity.Property(e => e.IdCidade).HasColumnName("Id_Cidade");

                entity.Property(e => e.LogComplemento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOG_COMPLEMENTO");

                entity.Property(e => e.LogStatusTipoLog)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LOG_STATUS_TIPO_LOG");

                entity.Property(e => e.LogTipoLogradouro)
                    .IsRequired()
                    .HasMaxLength(72)
                    .IsUnicode(false)
                    .HasColumnName("LOG_TIPO_LOGRADOURO");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdBairroNavigation)
                    .WithMany(p => p.Logradouros)
                    .HasForeignKey(d => d.IdBairro)
                    .HasConstraintName("FK_Logradouros_Bairros");

                entity.HasOne(d => d.IdCidadeNavigation)
                    .WithMany(p => p.Logradouros)
                    .HasForeignKey(d => d.IdCidade)
                    .HasConstraintName("FK_Logradouros_Cidades");
            });

            modelBuilder.Entity<MateriaisGrupo>(entity =>
            {
                entity.ToTable("Materiais_Grupos");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<MateriaisTipo>(entity =>
            {
                entity.ToTable("Materiais_Tipos");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdMateriaisGrupo).HasColumnName("Id_Materiais_Grupo");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Motivo>(entity =>
            {
                entity.Property(e => e.Abreviado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<MotivosBanco>(entity =>
            {
                entity.ToTable("Motivos_Bancos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.IdOcorrencia).HasColumnName("Id_Ocorrencia");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdOcorrenciaNavigation)
                    .WithMany(p => p.MotivosBancos)
                    .HasForeignKey(d => d.IdOcorrencia)
                    .HasConstraintName("FK_Motivos_Bancos_Ocorrencias_Bancos");
            });

            modelBuilder.Entity<MotivosBancos1>(entity =>
            {
                entity.ToTable("Motivos_Bancos1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.IdOcorrencia).HasColumnName("Id_Ocorrencia");
            });

            modelBuilder.Entity<Nf>(entity =>
            {
                entity.ToTable("NF");

                entity.HasIndex(e => e.Numero, "IX_NF")
                    .IsUnique();

                entity.HasIndex(e => e.Numero, "IX_NF_1")
                    .IsUnique();

                entity.Property(e => e.AliqIcms).HasColumnName("Aliq_ICMS");

                entity.Property(e => e.Aumento).HasColumnType("money");

                entity.Property(e => e.Autorizacao)
                    .HasMaxLength(44)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCalculoIcms).HasColumnName("Base_Calculo_ICMS");

                entity.Property(e => e.BaseCalculoIcmsSubstituicao).HasColumnName("Base_Calculo_ICMS_Substituicao");

                entity.Property(e => e.ConverteVolume).HasColumnName("Converte_Volume");

                entity.Property(e => e.Cst).HasColumnName("CST");

                entity.Property(e => e.DataEmbarque)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Embarque");

                entity.Property(e => e.DataEmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Emissao");

                entity.Property(e => e.DataEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Entrada");

                entity.Property(e => e.DataEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Entrega");

                entity.Property(e => e.DataProtocolo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Data_Protocolo");

                entity.Property(e => e.DataSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Saida");

                entity.Property(e => e.DataTransferencia)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Transferencia");

                entity.Property(e => e.Desconto).HasColumnType("money");

                entity.Property(e => e.Dv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DV");

                entity.Property(e => e.EnviadaNfe).HasColumnName("Enviada_NFe");

                entity.Property(e => e.Especie)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormaPagamento).HasColumnName("Forma_Pagamento");

                entity.Property(e => e.FretePorConta).HasColumnName("Frete_Por_Conta");

                entity.Property(e => e.HoraEmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("Hora_Emissao");

                entity.Property(e => e.HoraSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("Hora_Saida");

                entity.Property(e => e.Icms).HasColumnName("ICMS");

                entity.Property(e => e.IdCfop).HasColumnName("Id_CFOP");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdConta).HasColumnName("Id_Conta");

                entity.Property(e => e.IdDest).HasColumnName("idDest");

                entity.Property(e => e.IdFornecedor).HasColumnName("Id_Fornecedor");

                entity.Property(e => e.IdPedidoFechado).HasColumnName("Id_Pedido_Fechado");

                entity.Property(e => e.IdRedespacho).HasColumnName("Id_Redespacho");

                entity.Property(e => e.IdRepresentante).HasColumnName("Id_Representante");

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.ImpDanfe)
                    .HasColumnName("Imp_Danfe")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpExt).HasColumnName("Imp_Ext");

                entity.Property(e => e.Impresso).HasDefaultValueSql("((0))");

                entity.Property(e => e.IndFinal).HasColumnName("indFinal");

                entity.Property(e => e.IndPres).HasColumnName("indPres");

                entity.Property(e => e.Manual).HasDefaultValueSql("((0))");

                entity.Property(e => e.Marca)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTransportadora)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Transportadora");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Obs1).HasColumnType("text");

                entity.Property(e => e.Obs2).HasColumnType("text");

                entity.Property(e => e.OutrasDespesas)
                    .HasColumnType("money")
                    .HasColumnName("Outras_Despesas");

                entity.Property(e => e.PagOutros)
                    .HasColumnName("Pag_Outros")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pagamento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pagamentos)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PesoBruto).HasColumnName("Peso_Bruto");

                entity.Property(e => e.PesoLiquido).HasColumnName("Peso_Liquido");

                entity.Property(e => e.PlacaVeiculo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Placa_Veiculo");

                entity.Property(e => e.PlacaVeiculoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Placa_Veiculo_UF");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RedIcms).HasColumnName("Red_ICMS");

                entity.Property(e => e.Serie)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Valor01)
                    .HasColumnType("money")
                    .HasColumnName("Valor_01");

                entity.Property(e => e.Valor02)
                    .HasColumnType("money")
                    .HasColumnName("Valor_02");

                entity.Property(e => e.Valor03)
                    .HasColumnType("money")
                    .HasColumnName("Valor_03");

                entity.Property(e => e.Valor04)
                    .HasColumnType("money")
                    .HasColumnName("Valor_04");

                entity.Property(e => e.Valor05)
                    .HasColumnType("money")
                    .HasColumnName("Valor_05");

                entity.Property(e => e.Valor06)
                    .HasColumnType("money")
                    .HasColumnName("Valor_06");

                entity.Property(e => e.ValorFrete)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Frete");

                entity.Property(e => e.ValorIcms).HasColumnName("Valor_ICMS");

                entity.Property(e => e.ValorIcmsSubstituicao).HasColumnName("Valor_ICMS_Substituicao");

                entity.Property(e => e.ValorSeguro)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Seguro");

                entity.Property(e => e.ValorTotalIpi).HasColumnName("Valor_Total_IPI");

                entity.Property(e => e.ValorTotalNota)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Total_Nota");

                entity.Property(e => e.ValorTotalProdutos)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Total_Produtos");

                entity.Property(e => e.Vencimento01)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_01");

                entity.Property(e => e.Vencimento02)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_02");

                entity.Property(e => e.Vencimento03)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_03");

                entity.Property(e => e.Vencimento04)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_04");

                entity.Property(e => e.Vencimento05)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_05");

                entity.Property(e => e.Vencimento06)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_06");
            });

            modelBuilder.Entity<NfCancelada>(entity =>
            {
                entity.ToTable("NF_Canceladas");

                entity.Property(e => e.AliqIcms).HasColumnName("Aliq_ICMS");

                entity.Property(e => e.Aumento).HasColumnType("money");

                entity.Property(e => e.Autorizacao)
                    .HasMaxLength(44)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCalculoIcms).HasColumnName("Base_Calculo_ICMS");

                entity.Property(e => e.BaseCalculoIcmsSubstituicao).HasColumnName("Base_Calculo_ICMS_Substituicao");

                entity.Property(e => e.ConverteVolume).HasColumnName("Converte_Volume");

                entity.Property(e => e.Cst).HasColumnName("CST");

                entity.Property(e => e.DataEmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Emissao");

                entity.Property(e => e.DataEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Entrada");

                entity.Property(e => e.DataProtocolo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Data_Protocolo");

                entity.Property(e => e.DataSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Saida");

                entity.Property(e => e.Desconto).HasColumnType("money");

                entity.Property(e => e.EnviadaNfe).HasColumnName("Enviada_NFe");

                entity.Property(e => e.Especie)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormaPagamento).HasColumnName("Forma_Pagamento");

                entity.Property(e => e.FretePorConta).HasColumnName("Frete_Por_Conta");

                entity.Property(e => e.HoraEmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("Hora_Emissao");

                entity.Property(e => e.HoraSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("Hora_Saida");

                entity.Property(e => e.Icms).HasColumnName("ICMS");

                entity.Property(e => e.IdCfop).HasColumnName("Id_CFOP");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdConta).HasColumnName("Id_Conta");

                entity.Property(e => e.IdDest).HasColumnName("idDest");

                entity.Property(e => e.IdFornecedor).HasColumnName("Id_Fornecedor");

                entity.Property(e => e.IdPedidoFechado).HasColumnName("Id_Pedido_Fechado");

                entity.Property(e => e.IdRedespacho).HasColumnName("Id_Redespacho");

                entity.Property(e => e.IdRepresentante).HasColumnName("Id_Representante");

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.ImpDanfe)
                    .HasColumnName("Imp_Danfe")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpExt).HasColumnName("Imp_Ext");

                entity.Property(e => e.Impresso).HasDefaultValueSql("((0))");

                entity.Property(e => e.IndFinal).HasColumnName("indFinal");

                entity.Property(e => e.IndPres).HasColumnName("indPres");

                entity.Property(e => e.Marca)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTransportadora)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Transportadora");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Obs1).HasColumnType("text");

                entity.Property(e => e.Obs2).HasColumnType("text");

                entity.Property(e => e.OutrasDespesas)
                    .HasColumnType("money")
                    .HasColumnName("Outras_Despesas");

                entity.Property(e => e.PagOutros)
                    .HasColumnName("Pag_Outros")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pagamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pagamentos)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PesoBruto).HasColumnName("Peso_Bruto");

                entity.Property(e => e.PesoLiquido).HasColumnName("Peso_Liquido");

                entity.Property(e => e.PlacaVeiculo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Placa_Veiculo");

                entity.Property(e => e.PlacaVeiculoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Placa_Veiculo_UF");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RedIcms).HasColumnName("Red_ICMS");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCliente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Cliente");

                entity.Property(e => e.Valor01)
                    .HasColumnType("money")
                    .HasColumnName("Valor_01");

                entity.Property(e => e.Valor02)
                    .HasColumnType("money")
                    .HasColumnName("Valor_02");

                entity.Property(e => e.Valor03)
                    .HasColumnType("money")
                    .HasColumnName("Valor_03");

                entity.Property(e => e.Valor04)
                    .HasColumnType("money")
                    .HasColumnName("Valor_04");

                entity.Property(e => e.Valor05)
                    .HasColumnType("money")
                    .HasColumnName("Valor_05");

                entity.Property(e => e.Valor06)
                    .HasColumnType("money")
                    .HasColumnName("Valor_06");

                entity.Property(e => e.ValorFrete)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Frete");

                entity.Property(e => e.ValorIcms).HasColumnName("Valor_ICMS");

                entity.Property(e => e.ValorIcmsSubstituicao).HasColumnName("Valor_ICMS_Substituicao");

                entity.Property(e => e.ValorSeguro)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Seguro");

                entity.Property(e => e.ValorTotalIpi).HasColumnName("Valor_Total_IPI");

                entity.Property(e => e.ValorTotalNota)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Total_Nota");

                entity.Property(e => e.ValorTotalProdutos)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Total_Produtos");

                entity.Property(e => e.Vencimento01)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_01");

                entity.Property(e => e.Vencimento02)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_02");

                entity.Property(e => e.Vencimento03)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_03");

                entity.Property(e => e.Vencimento04)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_04");

                entity.Property(e => e.Vencimento05)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_05");

                entity.Property(e => e.Vencimento06)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_06");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.NfCancelada)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("FK_NF_Canceladas_Fornecedores");
            });

            modelBuilder.Entity<NfCanceladasIten>(entity =>
            {
                entity.ToTable("NF_Canceladas_Itens");

                entity.Property(e => e.AliqIcms).HasColumnName("Aliq_ICMS");

                entity.Property(e => e.BaseCalcIcms).HasColumnName("Base_Calc_ICMS");

                entity.Property(e => e.BaseCalcIpi).HasColumnName("Base_Calc_IPI");

                entity.Property(e => e.Cst)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CST");

                entity.Property(e => e.IdInsumo).HasColumnName("Id_Insumo");

                entity.Property(e => e.IdNota).HasColumnName("Id_Nota");

                entity.Property(e => e.IdProduto).HasColumnName("Id_Produto");

                entity.Property(e => e.IdProdutoNovo).HasColumnName("Id_Produto_Novo");

                entity.Property(e => e.IdUnidade).HasColumnName("Id_Unidade");

                entity.Property(e => e.Ipi).HasColumnName("IPI");

                entity.Property(e => e.Modalidade)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.QtdVolume).HasColumnName("Qtd_Volume");

                entity.Property(e => e.RedIcms).HasColumnName("Red_ICMS");

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.Property(e => e.ValorIcms).HasColumnName("Valor_ICMS");

                entity.Property(e => e.ValorIpi).HasColumnName("Valor_IPI");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.NfCanceladasItens)
                    .HasForeignKey(d => d.IdInsumo)
                    .HasConstraintName("FK_NF_Canceladas_Itens_Insumos");

                entity.HasOne(d => d.IdNotaNavigation)
                    .WithMany(p => p.NfCanceladasItens)
                    .HasForeignKey(d => d.IdNota)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NF_Canceladas_Itens_NF_Canceladas");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.NfCanceladasItens)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_NF_Canceladas_Itens_Produtos");

                entity.HasOne(d => d.IdUnidadeNavigation)
                    .WithMany(p => p.NfCanceladasItens)
                    .HasForeignKey(d => d.IdUnidade)
                    .HasConstraintName("FK_NF_Canceladas_Itens_Unidades");
            });

            modelBuilder.Entity<NfCce>(entity =>
            {
                entity.ToTable("NF_CCe");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Fuso)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdNota).HasColumnName("Id_Nota");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Texto).HasColumnType("text");

                entity.HasOne(d => d.IdNotaNavigation)
                    .WithMany(p => p.NfCces)
                    .HasForeignKey(d => d.IdNota)
                    .HasConstraintName("FK_NF_CCe_NF");
            });

            modelBuilder.Entity<NfEntradaIten>(entity =>
            {
                entity.ToTable("NF_Entrada_Itens");

                entity.Property(e => e.AliqIcms).HasColumnName("Aliq_ICMS");

                entity.Property(e => e.Cst)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CST");

                entity.Property(e => e.IdCfop).HasColumnName("Id_CFOP");

                entity.Property(e => e.IdNfEntrada).HasColumnName("Id_NF_Entrada");

                entity.Property(e => e.Ipi).HasColumnName("IPI");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Produto)
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.RedIcms).HasColumnName("Red_ICMS");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.Property(e => e.ValorIpi).HasColumnName("Valor_IPI");

                entity.HasOne(d => d.IdCfopNavigation)
                    .WithMany(p => p.NfEntradaItens)
                    .HasForeignKey(d => d.IdCfop)
                    .HasConstraintName("FK_NF_Entrada_Itens_CFOP");

                entity.HasOne(d => d.IdNfEntradaNavigation)
                    .WithMany(p => p.NfEntradaItens)
                    .HasForeignKey(d => d.IdNfEntrada)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NF_Entrada_Itens_NF_Entrada");
            });

            modelBuilder.Entity<NfEntradum>(entity =>
            {
                entity.ToTable("NF_Entrada");

                entity.HasIndex(e => e.Lancamento, "IX_NF_Entrada_Lancamento")
                    .IsUnique();

                entity.Property(e => e.AliqIcms).HasColumnName("Aliq_ICMS");

                entity.Property(e => e.BaseCalculoIcms).HasColumnName("Base_Calculo_ICMS");

                entity.Property(e => e.CalculoIcmsSubstituicao).HasColumnName("Calculo_ICMS_Substituicao");

                entity.Property(e => e.Cfop)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CFOP");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.DataRecebimento)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Recebimento");

                entity.Property(e => e.Especie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCfop).HasColumnName("Id_CFOP");

                entity.Property(e => e.Ie)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("IE");

                entity.Property(e => e.Lancamento).HasColumnType("datetime");

                entity.Property(e => e.Mista).HasDefaultValueSql("((0))");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OutrasDespesas)
                    .HasColumnType("money")
                    .HasColumnName("Outras_Despesas");

                entity.Property(e => e.RedIcms).HasColumnName("Red_ICMS");

                entity.Property(e => e.Serie)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo1)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.Property(e => e.ValorIcms)
                    .HasColumnType("money")
                    .HasColumnName("Valor_ICMS");

                entity.Property(e => e.ValorIcmsSubstituicao)
                    .HasColumnType("money")
                    .HasColumnName("Valor_ICMS_Substituicao");

                entity.Property(e => e.ValorIpi)
                    .HasColumnType("money")
                    .HasColumnName("Valor_IPI");

                entity.Property(e => e.ValorTotalNota)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Total_Nota");

                entity.HasOne(d => d.IdCfopNavigation)
                    .WithMany(p => p.NfEntrada)
                    .HasForeignKey(d => d.IdCfop)
                    .HasConstraintName("FK_NF_Entrada_CFOP");
            });

            modelBuilder.Entity<NfInutilizacao>(entity =>
            {
                entity.ToTable("NF_Inutilizacao");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Fim)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdEmrpesa).HasColumnName("Id_Emrpesa");

                entity.Property(e => e.Inicio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Texto).HasColumnType("text");
            });

            modelBuilder.Entity<NfIten>(entity =>
            {
                entity.ToTable("NF_Itens");

                entity.Property(e => e.AliqCofins).HasColumnName("Aliq_COFINS");

                entity.Property(e => e.AliqIcms).HasColumnName("Aliq_ICMS");

                entity.Property(e => e.AliqIpi).HasColumnName("Aliq_IPI");

                entity.Property(e => e.AliqPis).HasColumnName("Aliq_PIS");

                entity.Property(e => e.BaseCalcIcms).HasColumnName("Base_Calc_ICMS");

                entity.Property(e => e.BaseCalcIpi).HasColumnName("Base_Calc_IPI");

                entity.Property(e => e.Cst)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CST");

                entity.Property(e => e.CstCofins)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CST_COFINS");

                entity.Property(e => e.CstIpi)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CST_IPI");

                entity.Property(e => e.CstPis)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CST_PIS");

                entity.Property(e => e.IdInsumo).HasColumnName("Id_Insumo");

                entity.Property(e => e.IdNota).HasColumnName("Id_Nota");

                entity.Property(e => e.IdProduto).HasColumnName("Id_Produto");

                entity.Property(e => e.IdProdutoNovo).HasColumnName("Id_Produto_Novo");

                entity.Property(e => e.IdUnidade).HasColumnName("Id_Unidade");

                entity.Property(e => e.Ipi).HasColumnName("IPI");

                entity.Property(e => e.Modalidade)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Origem).HasColumnName("origem");

                entity.Property(e => e.QtdVolume).HasColumnName("Qtd_Volume");

                entity.Property(e => e.RedIcms).HasColumnName("Red_ICMS");

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.Property(e => e.ValorCofins).HasColumnName("Valor_COFINS");

                entity.Property(e => e.ValorFrete)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Frete")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorIcms).HasColumnName("Valor_ICMS");

                entity.Property(e => e.ValorIpi).HasColumnName("Valor_IPI");

                entity.Property(e => e.ValorPis).HasColumnName("Valor_PIS");
            });

            modelBuilder.Entity<NfReferenciada>(entity =>
            {
                entity.ToTable("NF_Referenciadas");

                entity.Property(e => e.Ano)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.IdNf).HasColumnName("Id_NF");

                entity.Property(e => e.Mes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nf)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("NF");

                entity.Property(e => e.Nfe)
                    .HasMaxLength(44)
                    .IsUnicode(false)
                    .HasColumnName("NFe");

                entity.Property(e => e.Serie)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoNfe).HasColumnName("TipoNFe");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");
            });

            modelBuilder.Entity<Ocorrencia>(entity =>
            {
                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Executado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Funcionario)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdFornecedor).HasColumnName("Id_Fornecedor");

                entity.Property(e => e.IdFuncionario).HasColumnName("Id_Funcionario");

                entity.Property(e => e.IdRepresentante).HasColumnName("Id_Representante");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Texto).HasColumnType("text");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Ocorrencia)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Ocorrencias_Clientes");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.Ocorrencia)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("FK_Ocorrencias_Fornecedores");
            });

            modelBuilder.Entity<OcorrenciasBanco>(entity =>
            {
                entity.ToTable("Ocorrencias_Bancos");

                entity.Property(e => e.CodBanco)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<OcorrenciasConsumidor>(entity =>
            {
                entity.ToTable("Ocorrencias_Consumidor");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Executado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Funcionario)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdConsumidor).HasColumnName("Id_Consumidor");

                entity.Property(e => e.Texto).HasColumnType("text");

                entity.HasOne(d => d.IdConsumidorNavigation)
                    .WithMany(p => p.OcorrenciasConsumidors)
                    .HasForeignKey(d => d.IdConsumidor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ocorrencias_Consumidor_Consumidores");
            });

            modelBuilder.Entity<OcorrenciasLote>(entity =>
            {
                entity.ToTable("Ocorrencias_Lotes");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Executado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Funcionario)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdLote).HasColumnName("Id_Lote");

                entity.Property(e => e.Texto).HasColumnType("text");
            });

            modelBuilder.Entity<OcorrenciasMaquina>(entity =>
            {
                entity.ToTable("Ocorrencias_Maquinas");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Funcionario)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fuso)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdMaquina).HasColumnName("Id_Maquina");

                entity.Property(e => e.Texto).HasColumnType("text");
            });

            modelBuilder.Entity<OcorrenciasNf>(entity =>
            {
                entity.ToTable("Ocorrencias_NF");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Executado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Funcionario)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdNf).HasColumnName("Id_NF");

                entity.Property(e => e.Texto).HasColumnType("text");
            });

            modelBuilder.Entity<OcorrenciasPedidosFechado>(entity =>
            {
                entity.ToTable("Ocorrencias_Pedidos_Fechados");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Executado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Funcionario)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdPedido).HasColumnName("Id_Pedido");

                entity.Property(e => e.Texto).HasColumnType("text");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.OcorrenciasPedidosFechados)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ocorrencias_Pedidos_Fechados_Vendas_Pedidos_Fechados");
            });

            modelBuilder.Entity<OcorrenciasTransportadora>(entity =>
            {
                entity.ToTable("Ocorrencias_Transportadoras");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Executado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Funcionario)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.Texto).HasColumnType("text");
            });

            modelBuilder.Entity<Origem>(entity =>
            {
                entity.HasKey(e => e.IdOrigem);

                entity.ToTable("Origem");

                entity.Property(e => e.IdOrigem)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origem");

                entity.Property(e => e.Percentual).HasColumnName("percentual");
            });

            modelBuilder.Entity<Pagar>(entity =>
            {
                entity.ToTable("Pagar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataEmissao).HasColumnType("datetime");

                entity.Property(e => e.DataPagamento).HasColumnType("datetime");

                entity.Property(e => e.DataVencimento).HasColumnType("datetime");

                entity.Property(e => e.Desconto).HasColumnType("money");

                entity.Property(e => e.Entrada).HasColumnType("datetime");

                entity.Property(e => e.IdConta).HasColumnName("Id_Conta");

                entity.Property(e => e.IdDespesa).HasColumnName("Id_Despesa");

                entity.Property(e => e.IdForma).HasColumnName("Id_Forma");

                entity.Property(e => e.IdFornecedor).HasColumnName("Id_fornecedor");

                entity.Property(e => e.IdGrupoDespesa).HasColumnName("Id_Grupo_Despesa");

                entity.Property(e => e.Juros).HasColumnType("money");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ncheque)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NCheque");

                entity.Property(e => e.Nf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NF");

                entity.Property(e => e.Observacao).HasColumnType("text");

                entity.Property(e => e.Parcela)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.Property(e => e.ValorOriginal)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Original");

                entity.Property(e => e.ValorPago)
                    .HasColumnType("money")
                    .HasComputedColumnSql("(([Valor]+[juros])-[desconto])", false);

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.Pagars)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("FK_Pagar_Fornecedores");
            });

            modelBuilder.Entity<Paise>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodIbge)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Cod_IBGE")
                    .IsFixedLength(true);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Producao>(entity =>
            {
                entity.HasKey(e => e.IdProducao);

                entity.ToTable("Producao");

                entity.Property(e => e.IdProducao).HasColumnName("Id_Producao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.IdCor).HasColumnName("Id_Cor");

                entity.Property(e => e.IdFuncionario).HasColumnName("Id_Funcionario");

                entity.Property(e => e.IdItem).HasColumnName("Id_Item");

                entity.Property(e => e.IdItemFechado).HasColumnName("Id_Item_Fechado");

                entity.Property(e => e.IdPedido).HasColumnName("Id_Pedido");

                entity.Property(e => e.IdPedidoFechado).HasColumnName("Id_Pedido_Fechado");

                entity.Property(e => e.IdPedidoFechadoPedidos).HasColumnName("Id_Pedido_Fechado_Pedidos");

                entity.Property(e => e.IdProduto).HasColumnName("Id_Produto");

                entity.HasOne(d => d.IdCorNavigation)
                    .WithMany(p => p.Producaos)
                    .HasForeignKey(d => d.IdCor)
                    .HasConstraintName("FK_Producao_Cores");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.Producaos)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("FK_Producao_Funcionarios");

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.Producaos)
                    .HasForeignKey(d => d.IdItem)
                    .HasConstraintName("FK_Producao_Vendas_Pedidos_Itens");

                entity.HasOne(d => d.IdItemFechadoNavigation)
                    .WithMany(p => p.Producaos)
                    .HasForeignKey(d => d.IdItemFechado)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Producao_Vendas_Pedidos_Fechados_Pedidos_Itens");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Producaos)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK_Producao_Vendas_Pedidos");

                entity.HasOne(d => d.IdPedidoFechadoNavigation)
                    .WithMany(p => p.Producaos)
                    .HasForeignKey(d => d.IdPedidoFechado)
                    .HasConstraintName("FK_Producao_Vendas_Pedidos_Fechados");

                entity.HasOne(d => d.IdPedidoFechadoPedidosNavigation)
                    .WithMany(p => p.Producaos)
                    .HasForeignKey(d => d.IdPedidoFechadoPedidos)
                    .HasConstraintName("FK_Producao_Vendas_Pedidos_Fechados_Pedidos");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.Producaos)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_Producao_Produtos");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Produtos")
                    .IsUnique();

                entity.Property(e => e.AceitaBranco)
                    .HasColumnName("Aceita_Branco")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AceitaPreto)
                    .HasColumnName("Aceita_Preto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BloqueadoProducao)
                    .HasColumnName("Bloqueado_Producao")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BloqueadoVenda)
                    .HasColumnName("Bloqueado_Venda")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Branco).HasDefaultValueSql("((0))");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Atualizacao");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Cadastro");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescricaoReduzido)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Descricao_Reduzido");

                entity.Property(e => e.Fci)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FCI");

                entity.Property(e => e.FciAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("FCI_Atualizacao");

                entity.Property(e => e.FciPercentual)
                    .HasColumnType("money")
                    .HasColumnName("FCI_Percentual");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("GTIN");

                entity.Property(e => e.IdClassificacao).HasColumnName("Id_Classificacao");

                entity.Property(e => e.IdFabrica).HasColumnName("Id_Fabrica");

                entity.Property(e => e.IdProducao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Id_Producao");

                entity.Property(e => e.IdTitulo).HasColumnName("Id_Titulo");

                entity.Property(e => e.IdUnidade).HasColumnName("Id_Unidade");

                entity.Property(e => e.Ipi).HasColumnName("IPI");

                entity.Property(e => e.LimiteDiarioPeso).HasColumnName("Limite_Diario_Peso");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OrdemTabela).HasColumnName("Ordem_Tabela");

                entity.Property(e => e.Origem).HasComputedColumnSql("(case when [FCI_Percentual]>(40) AND [FCI_Percentual]<=(70) then (3) else case when [FCI_Percentual]>(70) then (8) else case when [FCI_Percentual]<=(40) then (5) else case when [FCI_Percentual] IS NULL then (0)  end end end end)", false);

                entity.Property(e => e.Peso).HasColumnType("numeric(18, 5)");

                entity.Property(e => e.PesoFioTinto)
                    .HasColumnType("money")
                    .HasColumnName("Peso_Fio_Tinto");

                entity.Property(e => e.PesoPorcentagem).HasColumnName("Peso_Porcentagem");

                entity.Property(e => e.Preto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Programar).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProgramarMinMeiaCaixa)
                    .HasColumnName("Programar_Min_Meia_Caixa")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProgramarMinUmaCaixa)
                    .HasColumnName("Programar_Min_Uma_Caixa")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantidadeEmbalagem).HasColumnName("Quantidade_Embalagem");

                entity.Property(e => e.QuantidadeVolume).HasColumnName("Quantidade_Volume");

                entity.Property(e => e.SubstTributaria).HasColumnName("Subst_Tributaria");

                entity.HasOne(d => d.IdClassificacaoNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdClassificacao)
                    .HasConstraintName("FK_Produtos_Classificacao_Fiscal");

                entity.HasOne(d => d.IdFabricaNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdFabrica)
                    .HasConstraintName("FK_Produtos_Fabricas");

                entity.HasOne(d => d.IdUnidadeNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdUnidade)
                    .HasConstraintName("FK_Produtos_Unidades");
            });

            modelBuilder.Entity<Ramo>(entity =>
            {
                entity.Property(e => e.Descricao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Receber>(entity =>
            {
                entity.ToTable("Receber");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Baixado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cheque)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Conta)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataOcorrencia)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Ocorrencia");

                entity.Property(e => e.DataRecebimento)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Recebimento");

                entity.Property(e => e.Desconto).HasColumnType("money");

                entity.Property(e => e.Emissao).HasColumnType("datetime");

                entity.Property(e => e.GeradoArquivo).HasColumnName("Gerado_Arquivo");

                entity.Property(e => e.IdBoleto).HasColumnName("Id_Boleto");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdConta).HasColumnName("Id_Conta");

                entity.Property(e => e.IdFormaPagamento).HasColumnName("Id_Forma_Pagamento");

                entity.Property(e => e.IdMotivo1).HasColumnName("Id_Motivo1");

                entity.Property(e => e.IdMotivo2).HasColumnName("Id_Motivo2");

                entity.Property(e => e.IdMotivo3).HasColumnName("Id_Motivo3");

                entity.Property(e => e.IdMotivo4).HasColumnName("Id_Motivo4");

                entity.Property(e => e.IdMotivo5).HasColumnName("Id_Motivo5");

                entity.Property(e => e.IdNota).HasColumnName("Id_Nota");

                entity.Property(e => e.IdOcorrencia).HasColumnName("Id_Ocorrencia");

                entity.Property(e => e.IdRemessa).HasColumnName("Id_Remessa");

                entity.Property(e => e.Juros).HasColumnType("money");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Nc)
                    .HasColumnName("NC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NF");

                entity.Property(e => e.NossoNumero)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Nosso_Numero");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Parcela)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.Property(e => e.ValorOriginal)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Original");

                entity.Property(e => e.ValorPago)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Pago");

                entity.Property(e => e.Vencimento).HasColumnType("datetime");

                entity.Property(e => e.VencimentoOriginal)
                    .HasColumnType("datetime")
                    .HasColumnName("Vencimento_Original");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Recebers)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Receber_Clientes");

                entity.HasOne(d => d.IdContaNavigation)
                    .WithMany(p => p.Recebers)
                    .HasForeignKey(d => d.IdConta)
                    .HasConstraintName("FK_Receber_CadContas");

                entity.HasOne(d => d.IdFormaPagamentoNavigation)
                    .WithMany(p => p.Recebers)
                    .HasForeignKey(d => d.IdFormaPagamento)
                    .HasConstraintName("FK_Receber_Forma_Pagamento");

                entity.HasOne(d => d.IdMotivo1Navigation)
                    .WithMany(p => p.ReceberIdMotivo1Navigations)
                    .HasForeignKey(d => d.IdMotivo1)
                    .HasConstraintName("FK_Receber_Motivos_Bancos");

                entity.HasOne(d => d.IdMotivo2Navigation)
                    .WithMany(p => p.ReceberIdMotivo2Navigations)
                    .HasForeignKey(d => d.IdMotivo2)
                    .HasConstraintName("FK_Receber_Motivos_Bancos1");

                entity.HasOne(d => d.IdMotivo3Navigation)
                    .WithMany(p => p.ReceberIdMotivo3Navigations)
                    .HasForeignKey(d => d.IdMotivo3)
                    .HasConstraintName("FK_Receber_Motivos_Bancos2");

                entity.HasOne(d => d.IdMotivo4Navigation)
                    .WithMany(p => p.ReceberIdMotivo4Navigations)
                    .HasForeignKey(d => d.IdMotivo4)
                    .HasConstraintName("FK_Receber_Motivos_Bancos3");

                entity.HasOne(d => d.IdMotivo5Navigation)
                    .WithMany(p => p.ReceberIdMotivo5Navigations)
                    .HasForeignKey(d => d.IdMotivo5)
                    .HasConstraintName("FK_Receber_Motivos_Bancos4");

                entity.HasOne(d => d.IdNotaNavigation)
                    .WithMany(p => p.Recebers)
                    .HasForeignKey(d => d.IdNota)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Receber_NF");

                entity.HasOne(d => d.IdOcorrenciaNavigation)
                    .WithMany(p => p.Recebers)
                    .HasForeignKey(d => d.IdOcorrencia)
                    .HasConstraintName("FK_Receber_Ocorrencias_Bancos");

                entity.HasOne(d => d.IdRemessaNavigation)
                    .WithMany(p => p.Recebers)
                    .HasForeignKey(d => d.IdRemessa)
                    .HasConstraintName("FK_Receber_Remessas");
            });

            modelBuilder.Entity<Remessa>(entity =>
            {
                entity.Property(e => e.Arquivo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reenvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.Sequencial)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Representante>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Representantes")
                    .IsUnique();

                entity.Property(e => e.Apelido)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bairro)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BairroEntrega)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Bairro_Entrega");

                entity.Property(e => e.Celular)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Celular1)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.CepEntrega)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP_Entrega");

                entity.Property(e => e.Ci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CI");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CidadeEntrega)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cidade_Entrega");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.CodIbgeEntrega)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Cod_IBGE_Entrega");

                entity.Property(e => e.CodUfEntrega)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Cod_UF_Entrega");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComplementoEntrega)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Complemento_Entrega");

                entity.Property(e => e.ContatoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Id");

                entity.Property(e => e.ContatoTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Tipo");

                entity.Property(e => e.Core)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.CrrpEstado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CRRP_Estado");

                entity.Property(e => e.CrrpNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRRP_Numero");

                entity.Property(e => e.DataAdmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Admissao");

                entity.Property(e => e.DataBloqueio)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Bloqueio");

                entity.Property(e => e.DataDemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Demissao");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Nascimento");

                entity.Property(e => e.DescontoFabrica).HasColumnName("Desconto_Fabrica");

                entity.Property(e => e.DescontoTabelaPreco).HasColumnName("Desconto_Tabela_preco");

                entity.Property(e => e.DiasFaturamento)
                    .HasColumnName("Dias_Faturamento")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoEntrega)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Entrega");

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IdFabrica).HasColumnName("Id_Fabrica");

                entity.Property(e => e.IdSetor).HasColumnName("Id_Setor");

                entity.Property(e => e.IdTabelaPreco).HasColumnName("Id_Tabela_Preco");

                entity.Property(e => e.Ie)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IE");

                entity.Property(e => e.InssCidade)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("INSS_Cidade");

                entity.Property(e => e.LimiteFaturado)
                    .HasColumnName("Limite_Faturado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MatriculaInss)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Matricula_INSS");

                entity.Property(e => e.MetasVenda).HasColumnName("Metas_Venda");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroEntrega).HasColumnName("Numero_Entrega");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Razao_Social");

                entity.Property(e => e.RecolheInss).HasColumnName("Recolhe_INSS");

                entity.Property(e => e.Rg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RG");

                entity.Property(e => e.SalarioBase)
                    .HasColumnType("money")
                    .HasColumnName("Salario_Base");

                entity.Property(e => e.Senha)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone1)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneEntrega)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Telefone_Entrega");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.Property(e => e.UfEntrega)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF_Entrega");

                entity.Property(e => e.UserName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTabelaPrecoNavigation)
                    .WithMany(p => p.Representantes)
                    .HasForeignKey(d => d.IdTabelaPreco)
                    .HasConstraintName("FK_Representantes_Tabela_Preco");
            });

            modelBuilder.Entity<RepresentantesConta>(entity =>
            {
                entity.ToTable("Representantes_Contas");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Conta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("Conta_Desde");

                entity.Property(e => e.DigitoAgencia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Digito_Agencia");

                entity.Property(e => e.DigitoConta)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Digito_Conta");

                entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");

                entity.Property(e => e.IdOutroBanco).HasColumnName("Id_Outro_Banco");

                entity.Property(e => e.IdRepresentante).HasColumnName("Id_Representante");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NomeAgencia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Agencia");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Titular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.RepresentantesContaIdBancoNavigations)
                    .HasForeignKey(d => d.IdBanco)
                    .HasConstraintName("FK_Representantes_Contas_Bancos");

                entity.HasOne(d => d.IdOutroBancoNavigation)
                    .WithMany(p => p.RepresentantesContaIdOutroBancoNavigations)
                    .HasForeignKey(d => d.IdOutroBanco)
                    .HasConstraintName("FK_Representantes_Contas_Bancos1");

                entity.HasOne(d => d.IdRepresentanteNavigation)
                    .WithMany(p => p.RepresentantesConta)
                    .HasForeignKey(d => d.IdRepresentante)
                    .HasConstraintName("FK_Representantes_Contas_Representantes");
            });

            modelBuilder.Entity<RepresentantesContato>(entity =>
            {
                entity.ToTable("Representantes_Contatos");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ContatoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Id");

                entity.Property(e => e.ContatoTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Tipo");

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IdRepresentante).HasColumnName("Id_Representante");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ramal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRepresentanteNavigation)
                    .WithMany(p => p.RepresentantesContatos)
                    .HasForeignKey(d => d.IdRepresentante)
                    .HasConstraintName("FK_Representantes_Contatos_Representantes");
            });

            modelBuilder.Entity<RepresentantesProdutosDesconto>(entity =>
            {
                entity.ToTable("Representantes_Produtos_Descontos");

                entity.Property(e => e.IdProduto).HasColumnName("Id_Produto");

                entity.Property(e => e.IdRepresentante).HasColumnName("Id_Representante");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.RepresentantesProdutosDescontos)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_Representantes_Produtos_Descontos_Produtos");

                entity.HasOne(d => d.IdRepresentanteNavigation)
                    .WithMany(p => p.RepresentantesProdutosDescontos)
                    .HasForeignKey(d => d.IdRepresentante)
                    .HasConstraintName("FK_Representantes_Produtos_Descontos_Representantes");
            });

            modelBuilder.Entity<RepresentantesRegio>(entity =>
            {
                entity.ToTable("Representantes_Regioes");

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.IdRepresentante).HasColumnName("Id_Representante");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdRepresentanteNavigation)
                    .WithMany(p => p.RepresentantesRegios)
                    .HasForeignKey(d => d.IdRepresentante)
                    .HasConstraintName("FK_Representantes_Regioes_Representantes");
            });

            modelBuilder.Entity<Retorno>(entity =>
            {
                entity.ToTable("Retorno");

                entity.Property(e => e.Arquivo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Saldo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Entrada)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Fechado).HasDefaultValueSql("(0)");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Saida)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Saldo1)
                    .HasColumnType("money")
                    .HasColumnName("Saldo")
                    .HasComputedColumnSql("([SaldoAnterior] + [Entrada] - [Saida])", false);

                entity.Property(e => e.SaldoAnterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Setore>(entity =>
            {
                entity.HasIndex(e => e.Descricao, "IX_Setores")
                    .IsUnique();

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdDivisao).HasColumnName("Id_Divisao");

                entity.Property(e => e.IdFabrica).HasColumnName("Id_Fabrica");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdDivisaoNavigation)
                    .WithMany(p => p.Setores)
                    .HasForeignKey(d => d.IdDivisao)
                    .HasConstraintName("FK_Producoes_Fabricas");

                entity.HasOne(d => d.IdFabricaNavigation)
                    .WithMany(p => p.Setores)
                    .HasForeignKey(d => d.IdFabrica)
                    .HasConstraintName("FK_Setores_Fabricas");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiasLimites).HasColumnName("Dias_Limites");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<TabelaPreco>(entity =>
            {
                entity.ToTable("Tabela_Preco");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<TabelaPrecoProduto>(entity =>
            {
                entity.ToTable("Tabela_Preco_Produtos");

                entity.Property(e => e.IdProduto).HasColumnName("Id_Produto");

                entity.Property(e => e.IdTabela).HasColumnName("Id_Tabela");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Preco).HasColumnType("money");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TabelaPrecoProdutos)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_Tabela_Preco_Itens_Produtos");

                entity.HasOne(d => d.IdTabelaNavigation)
                    .WithMany(p => p.TabelaPrecoProdutos)
                    .HasForeignKey(d => d.IdTabela)
                    .HasConstraintName("FK_Tabela_Preco_Itens_Tabela_Preco");
            });

            modelBuilder.Entity<TipoAgendamento>(entity =>
            {
                entity.ToTable("Tipo_Agendamento");

                entity.Property(e => e.Bloqueado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transferencia>(entity =>
            {
                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.IdContaDestino).HasColumnName("Id_Conta_Destino");

                entity.Property(e => e.IdContaOrigem).HasColumnName("Id_Conta_Origem");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.HasOne(d => d.IdContaDestinoNavigation)
                    .WithMany(p => p.TransferenciaIdContaDestinoNavigations)
                    .HasForeignKey(d => d.IdContaDestino)
                    .HasConstraintName("FK_Transferencias_CadContas");

                entity.HasOne(d => d.IdContaOrigemNavigation)
                    .WithMany(p => p.TransferenciaIdContaOrigemNavigations)
                    .HasForeignKey(d => d.IdContaOrigem)
                    .HasConstraintName("FK_Transferencias_CadContas1");
            });

            modelBuilder.Entity<Transportadora>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Transportadoras")
                    .IsUnique();

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cgc)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CGC");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Coleta).HasDefaultValueSql("((0))");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContaContabil)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Conta_Contabil");

                entity.Property(e => e.ContatoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Id");

                entity.Property(e => e.ContatoTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Tipo");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.DataBloqueio)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Bloqueio");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Cadastro");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EmailNfe)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EmailNFe");

                entity.Property(e => e.EmailNfe2)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EmailNFe2");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Entrega).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.Ie)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IE");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Fantasia");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Placa)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PlacaUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Placa_UF");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Razao_Social");

                entity.Property(e => e.Redespacho).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RG");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone1)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.HasOne(d => d.IdTransportadoraNavigation)
                    .WithMany(p => p.InverseIdTransportadoraNavigation)
                    .HasForeignKey(d => d.IdTransportadora)
                    .HasConstraintName("FK_Transportadoras_Transportadoras");
            });

            modelBuilder.Entity<TransportadorasColetum>(entity =>
            {
                entity.ToTable("Transportadoras_Coleta");

                entity.Property(e => e.Domingo).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.Quarta).HasDefaultValueSql("((1))");

                entity.Property(e => e.Quinta).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sabado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Segunda).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sexta).HasDefaultValueSql("((1))");

                entity.Property(e => e.Terca).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TransportadorasConta>(entity =>
            {
                entity.ToTable("Transportadoras_Contas");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Conta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("Conta_Desde");

                entity.Property(e => e.DigitoAgencia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Digito_Agencia");

                entity.Property(e => e.DigitoConta)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Digito_Conta");

                entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");

                entity.Property(e => e.IdOutroBanco).HasColumnName("Id_Outro_Banco");

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NomeAgencia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Agencia");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Titular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.TransportadorasContaIdBancoNavigations)
                    .HasForeignKey(d => d.IdBanco)
                    .HasConstraintName("FK_Transportadoras_Contas_Bancos");

                entity.HasOne(d => d.IdOutroBancoNavigation)
                    .WithMany(p => p.TransportadorasContaIdOutroBancoNavigations)
                    .HasForeignKey(d => d.IdOutroBanco)
                    .HasConstraintName("FK_Transportadoras_Contas_Bancos1");

                entity.HasOne(d => d.IdTransportadoraNavigation)
                    .WithMany(p => p.TransportadorasConta)
                    .HasForeignKey(d => d.IdTransportadora)
                    .HasConstraintName("FK_Transportadoras_Contas_Transportadoras");
            });

            modelBuilder.Entity<TransportadorasContato>(entity =>
            {
                entity.ToTable("Transportadoras_Contatos");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ContatoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Id");

                entity.Property(e => e.ContatoTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Contato_Tipo");

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.Matriz)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ramal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.HasOne(d => d.IdTransportadoraNavigation)
                    .WithMany(p => p.TransportadorasContatos)
                    .HasForeignKey(d => d.IdTransportadora)
                    .HasConstraintName("FK_Transportadoras_Contatos_Transportadoras");
            });

            modelBuilder.Entity<TransportadorasRegio>(entity =>
            {
                entity.ToTable("Transportadoras_Regioes");

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.Matriz)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.HasOne(d => d.IdTransportadoraNavigation)
                    .WithMany(p => p.TransportadorasRegios)
                    .HasForeignKey(d => d.IdTransportadora)
                    .HasConstraintName("FK_Transportadoras_Regioes_Transportadoras");
            });

            modelBuilder.Entity<Unidade>(entity =>
            {
                entity.HasIndex(e => e.Descricao, "IX_Unidades")
                    .IsUnique();

                entity.Property(e => e.Abreviado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Expirou).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFuncionario).HasColumnName("Id_Funcionario");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MnuAltTitulo).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuAnaliseEstoques).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuAutoclaves).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuAutoclavesCapacidades)
                    .HasColumnName("MnuAutoclaves_Capacidades")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuAutoclavesCores)
                    .HasColumnName("MnuAutoclaves_Cores")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuBancosRegioes).HasColumnName("MnuBancos_Regioes");

                entity.Property(e => e.MnuBelcone).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuBlocoK).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuCancelarArquivoRemessa).HasColumnName("MnuCancelar_Arquivo_Remessa");

                entity.Property(e => e.MnuCancelarNf).HasColumnName("MnuCancelar_NF");

                entity.Property(e => e.MnuCartelas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuCatalogo).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuCfop).HasColumnName("MnuCFOP");

                entity.Property(e => e.MnuCfopItens).HasColumnName("MnuCFOP_Itens");

                entity.Property(e => e.MnuClientesAssociados).HasColumnName("MnuClientes_Associados");

                entity.Property(e => e.MnuClientesProdutosDesconto).HasColumnName("MnuClientes_Produtos_Desconto");

                entity.Property(e => e.MnuConferente).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuCustoProducao).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuDespesasGrupos).HasColumnName("MnuDespesas_Grupos");

                entity.Property(e => e.MnuEmailComercial).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuEmailFinanceiro).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuEmailNfe)
                    .HasColumnName("MnuEmailNFe")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuEmailPedidos).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuEmailPedidosVista).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuEmbalador).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuEntradaInsumos).HasColumnName("MnuEntrada_Insumos");

                entity.Property(e => e.MnuEstoqueFioTinto)
                    .HasColumnName("MnuEstoque_Fio_Tinto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuEstoqueProdutoAcabado)
                    .HasColumnName("MnuEstoque_Produto_Acabado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuEtiquetasAvulsas).HasColumnName("MnuEtiquetas_Avulsas");

                entity.Property(e => e.MnuEtiquetasCartelas)
                    .HasColumnName("MnuEtiquetas_Cartelas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuExcPedRej)
                    .HasColumnName("MnuExc_Ped_Rej")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFaltas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFci)
                    .HasColumnName("MnuFCI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaAmostraTingimento).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaBalancoFioTinto).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaBalancoProdutoAcabado).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaConicaleiraLongo).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaControleEpi)
                    .HasColumnName("MnuFichaControleEPI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaFaltas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaPerdas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaPlacaPedidoFechado)
                    .HasColumnName("MnuFichaPlaca_Pedido_Fechado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaPrateleiraProdAcab).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaRecrutamento).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaUniformes).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuFichaViconeirasTubeteiras).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuGerarArquivoRemessa).HasColumnName("MnuGerar_Arquivo_Remessa");

                entity.Property(e => e.MnuGerarPdf)
                    .HasColumnName("MnuGerarPDF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuImprimirCheques)
                    .HasColumnName("MnuImprimir_Cheques")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuImprimirCodigoBarras)
                    .HasColumnName("MnuImprimir_Codigo_Barras")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuImprimirEtiquetas).HasColumnName("MnuImprimir_Etiquetas");

                entity.Property(e => e.MnuImprimirLotes)
                    .HasColumnName("MnuImprimir_Lotes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuLotes).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuLotesAprova).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuLotesReprova).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuLotesTintos)
                    .HasColumnName("MnuLotes_Tintos")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuMaquinas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuMateriaisGrupos).HasColumnName("MnuMateriais_Grupos");

                entity.Property(e => e.MnuMateriaisTipos).HasColumnName("MnuMateriais_Tipos");

                entity.Property(e => e.MnuMovimentacaoFioTinto)
                    .HasColumnName("MnuMovimentacao_Fio_Tinto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuNfEntrada).HasColumnName("MnuNF_Entrada");

                entity.Property(e => e.MnuNfManual).HasColumnName("Mnu_NF_Manual");

                entity.Property(e => e.MnuNfe).HasColumnName("MnuNFe");

                entity.Property(e => e.MnuOcorrenciaMaquinas)
                    .HasColumnName("MnuOcorrencia_Maquinas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuOcorrenciaMaquinas2)
                    .HasColumnName("MnuOcorrencia_Maquinas2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuPagar).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuPedidosCompras).HasColumnName("MnuPedidos_Compras");

                entity.Property(e => e.MnuPedidosFechados).HasColumnName("MnuPedidos_Fechados");

                entity.Property(e => e.MnuPedidosFechadosFaturar).HasColumnName("MnuPedidos_Fechados_Faturar");

                entity.Property(e => e.MnuPedidosFechadosProducao)
                    .HasColumnName("MnuPedidos_Fechados_Producao")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuPedidosInsumos).HasColumnName("MnuPedidos_Insumos");

                entity.Property(e => e.MnuProcessarCte)
                    .HasColumnName("MnuProcessarCTe")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuProdutoAcabadoAjuste).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuProgramacaoFioTinto).HasColumnName("MnuProgramacao_Fio_Tinto");

                entity.Property(e => e.MnuProgramacaoMaquinas)
                    .HasColumnName("MnuProgramacao_Maquinas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuProgramacaoMaquinasProdutos)
                    .HasColumnName("MnuProgramacao_Maquinas_Produtos")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuProgramasTingimento)
                    .HasColumnName("MnuProgramas_Tingimento")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuReceitas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuReimprimirNf).HasColumnName("MnuReimprimirNF");

                entity.Property(e => e.MnuRelComparativoProducao).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelCores).HasColumnName("MnuRel_Cores");

                entity.Property(e => e.MnuRelCores1).HasColumnName("MnuRelCores");

                entity.Property(e => e.MnuRelCoresAutoclaves)
                    .HasColumnName("MnuRelCores_Autoclaves")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelCoresFaturadas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelCte)
                    .HasColumnName("MnuRelCTe")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelCustoLote).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelCustoReceitas)
                    .HasColumnName("MnuRelCusto_Receitas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelEmbalador).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelEntregaCartelas)
                    .HasColumnName("MnuRelEntrega_Cartelas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelFaltas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelFioTinto).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelFluxoCaixa).HasColumnName("MnuRelFluxo_Caixa");

                entity.Property(e => e.MnuRelFluxoGerencial).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelGerencialVendas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelGerencialdeProducao).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelInventarioEstoque).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelListagemFioTinto).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelListagemProdutoAcabado).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelMetasVenda).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelPedidos).HasColumnName("MnuRel_Pedidos");

                entity.Property(e => e.MnuRelPedidos1).HasColumnName("MnuRelPedidos");

                entity.Property(e => e.MnuRelPedidosFechados).HasColumnName("MnuRelPedidos_Fechados");

                entity.Property(e => e.MnuRelPrevisaoProdutosProducao)
                    .HasColumnName("MnuRelPrevisao_Produtos_Producao")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelProducaoMaquinas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelProducaoTinturaria)
                    .HasColumnName("MnuRelProducao_Tinturaria")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelProdutoAcabado).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelProdutosProducao)
                    .HasColumnName("MnuRelProdutos_Producao")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelProgramacaoLotes).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelRankingVendas).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelTinturaria).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelTransportadorasCidades)
                    .HasColumnName("MnuRelTransportadoras_Cidades")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRelVendaAnual).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuRepresentantesProdutosDescontos).HasColumnName("MnuRepresentantes_Produtos_Descontos");

                entity.Property(e => e.MnuRepresentantesRegioes).HasColumnName("MnuRepresentantes_Regioes");

                entity.Property(e => e.MnuSelecao).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuSenhaRepresentante1).HasColumnName("MnuSenha_Representante");

                entity.Property(e => e.MnuSenhaRepresentantes).HasColumnName("MnuSenha_Representantes");

                entity.Property(e => e.MnuSolicitacaoMaterial)
                    .HasColumnName("MnuSolicitacao_Material")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuSolicitarMaterial)
                    .HasColumnName("MnuSolicitar_Material")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuTabelaPadrao).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuTabelaPreco).HasColumnName("MnuTabela_Preco");

                entity.Property(e => e.MnuTabelaPrecoProdutos).HasColumnName("MnuTabela_Preco_Produtos");

                entity.Property(e => e.MnuTinturaria).HasDefaultValueSql("((0))");

                entity.Property(e => e.MnuTiposContatos).HasColumnName("MnuTipos_Contatos");

                entity.Property(e => e.MnuTransportadorasContatos).HasColumnName("MnuTransportadoras_Contatos");

                entity.Property(e => e.MnuTransportadorasRegioes).HasColumnName("MnuTransportadoras_Regioes");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Nome)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ulogin)
                    .HasColumnType("datetime")
                    .HasColumnName("ULogin");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("FK_Usuarios_Funcionarios");
            });

            modelBuilder.Entity<VendasPedido>(entity =>
            {
                entity.ToTable("Vendas_Pedidos");

                entity.HasIndex(e => e.Emissao, "IX_Vendas_Pedidos");

                entity.Property(e => e.Aberto).HasColumnType("datetime");

                entity.Property(e => e.Bloqueado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cadastrado).HasColumnType("datetime");

                entity.Property(e => e.CodRep)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmAtraso).HasComputedColumnSql("([dbo].[EmAtraso]([Cadastrado],[Liberado],[Aberto],[Fechado],[Faturado],[Embarcado],getdate()))", false);

                entity.Property(e => e.Embarcado).HasColumnType("datetime");

                entity.Property(e => e.Emissao).HasColumnType("datetime");

                entity.Property(e => e.EmissaoAntes)
                    .HasColumnType("datetime")
                    .HasColumnName("Emissao_Antes");

                entity.Property(e => e.Executado).HasComputedColumnSql("([Faturado_])", false);

                entity.Property(e => e.Faturado).HasColumnType("datetime");

                entity.Property(e => e.Faturado1)
                    .HasColumnName("Faturado_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fechado).HasColumnType("datetime");

                entity.Property(e => e.FormaPagamento).HasColumnName("Forma_Pagamento");

                entity.Property(e => e.FreteRedespacho)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FreteTransportadora)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdRedespacho).HasColumnName("Id_Redespacho");

                entity.Property(e => e.IdRepresentante).HasColumnName("Id_Representante");

                entity.Property(e => e.IdStatus).HasColumnName("Id_Status");

                entity.Property(e => e.IdTransportadora)
                    .HasColumnName("Id_Transportadora")
                    .HasDefaultValueSql("((2898))");

                entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");

                entity.Property(e => e.Liberado).HasColumnType("datetime");

                entity.Property(e => e.Liberar).HasDefaultValueSql("((0))");

                entity.Property(e => e.Msg).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ObsAberto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Obs_Aberto");

                entity.Property(e => e.PedidoCompra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Pedido_Compra");

                entity.Property(e => e.PedidoFinalizado)
                    .HasColumnName("Pedido_Finalizado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Polycron).HasDefaultValueSql("((0))");

                entity.Property(e => e.Prazo1).HasColumnName("Prazo_1");

                entity.Property(e => e.Prazo2).HasColumnName("Prazo_2");

                entity.Property(e => e.Prazo3).HasColumnName("Prazo_3");

                entity.Property(e => e.Prazo4).HasColumnName("Prazo_4");

                entity.Property(e => e.Prazo5).HasColumnName("Prazo_5");

                entity.Property(e => e.Prazo6).HasColumnName("Prazo_6");

                entity.Property(e => e.PrevisaoFaturamento)
                    .HasColumnType("datetime")
                    .HasColumnName("Previsao_Faturamento");

                entity.Property(e => e.Rejeitado).HasColumnType("datetime");

                entity.Property(e => e.Rejeitar).HasDefaultValueSql("((0))");

                entity.Property(e => e.Saldo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TxFrete)
                    .HasColumnName("TX_Frete")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorFrete)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Frete");

                entity.Property(e => e.VolumesExtra)
                    .HasColumnName("Volumes_Extra")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.VendasPedidos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_Vendas_Pedidos_Clientes_Usuarios");
            });

            modelBuilder.Entity<VendasPedidosFechado>(entity =>
            {
                entity.ToTable("Vendas_Pedidos_Fechados");

                entity.HasIndex(e => new { e.Finalizado, e.Id, e.IdCliente, e.IdTransportadora }, "_dta_index_Vendas_Pedidos_Fechados_9_560057081__K19_K1_K4_K5_2_3_7");

                entity.Property(e => e.Cep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodRep)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Faturado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Finalizado).HasDefaultValueSql("((0))");

                entity.Property(e => e.FormaPagamento).HasColumnName("Forma_Pagamento");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.HoraFechamento)
                    .HasColumnType("datetime")
                    .HasColumnName("Hora_Fechamento");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdFuncionario).HasColumnName("Id_Funcionario");

                entity.Property(e => e.IdTransportadora).HasColumnName("Id_Transportadora");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Novo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Obs)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Prazo1).HasColumnName("Prazo_1");

                entity.Property(e => e.Prazo2).HasColumnName("Prazo_2");

                entity.Property(e => e.Prazo3).HasColumnName("Prazo_3");

                entity.Property(e => e.Prazo4).HasColumnName("Prazo_4");

                entity.Property(e => e.Prazo5).HasColumnName("Prazo_5");

                entity.Property(e => e.Prazo6).HasColumnName("Prazo_6");

                entity.Property(e => e.PrevisaoFaturamento)
                    .HasColumnType("datetime")
                    .HasColumnName("Previsao_Faturamento");

                entity.Property(e => e.VolumesExtra)
                    .HasColumnName("Volumes_Extra")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.VendasPedidosFechados)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Faturas_Clientes");

                entity.HasOne(d => d.IdTransportadoraNavigation)
                    .WithMany(p => p.VendasPedidosFechados)
                    .HasForeignKey(d => d.IdTransportadora)
                    .HasConstraintName("FK_Vendas_Pedidos_Fechados_Transportadoras");
            });

            modelBuilder.Entity<VendasPedidosFechadosAlerta>(entity =>
            {
                entity.ToTable("Vendas_Pedidos_Fechados_Alertas");

                entity.Property(e => e.DataEnvio)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Envio");

                entity.Property(e => e.DataLeitura)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Leitura");

                entity.Property(e => e.Enviado).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFuncionario).HasColumnName("Id_Funcionario");

                entity.Property(e => e.IdPedido).HasColumnName("Id_Pedido");

                entity.Property(e => e.Lido).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.VendasPedidosFechadosAlerta)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("FK_Vendas_Pedidos_Fechados_Alertas_Funcionarios");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.VendasPedidosFechadosAlerta)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vendas_Pedidos_Fechados_Alertas_Vendas_Pedidos_Fechados");
            });

            modelBuilder.Entity<VendasPedidosFechadosExtra>(entity =>
            {
                entity.ToTable("Vendas_Pedidos_Fechados_Extras");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.IdExtra).HasColumnName("Id_Extra");

                entity.Property(e => e.IdFuncionario).HasColumnName("Id_Funcionario");

                entity.Property(e => e.IdPedidoFechado).HasColumnName("Id_Pedido_Fechado");

                entity.HasOne(d => d.IdPedidoFechadoNavigation)
                    .WithMany(p => p.VendasPedidosFechadosExtras)
                    .HasForeignKey(d => d.IdPedidoFechado)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vendas_Pedidos_Fechados_Extras_Vendas_Pedidos_Fechados");
            });

            modelBuilder.Entity<VendasPedidosFechadosFabrica>(entity =>
            {
                entity.HasKey(e => e.IdPedidoFechadoFabrica);

                entity.ToTable("Vendas_Pedidos_Fechados_Fabricas");

                entity.Property(e => e.IdPedidoFechadoFabrica).HasColumnName("Id_Pedido_Fechado_Fabrica");

                entity.Property(e => e.Corredor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.IdFabrica).HasColumnName("Id_Fabrica");

                entity.Property(e => e.IdFuncionario).HasColumnName("Id_Funcionario");

                entity.Property(e => e.IdPedidoFechado).HasColumnName("Id_Pedido_Fechado");

                entity.HasOne(d => d.IdPedidoFechadoNavigation)
                    .WithMany(p => p.VendasPedidosFechadosFabricas)
                    .HasForeignKey(d => d.IdPedidoFechado)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vendas_Pedidos_Fechados_Fabricas_Vendas_Pedidos_Fechados");
            });

            modelBuilder.Entity<VendasPedidosFechadosNovo>(entity =>
            {
                entity.ToTable("Vendas_Pedidos_Fechados_Novos");

                entity.Property(e => e.IdCoordenador).HasColumnName("Id_Coordenador");

                entity.Property(e => e.IdPedidoFechado).HasColumnName("Id_Pedido_Fechado");
            });

            modelBuilder.Entity<VendasPedidosFechadosPedido>(entity =>
            {
                entity.ToTable("Vendas_Pedidos_Fechados_Pedidos");

                entity.HasIndex(e => new { e.IdPedidoFechado, e.IdPedido }, "_dta_index_Vendas_Pedidos_Fechados_Pedidos_9_397960494__K2_K3");

                entity.Property(e => e.IdPedido).HasColumnName("Id_Pedido");

                entity.Property(e => e.IdPedidoFechado).HasColumnName("Id_Pedido_Fechado");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.VendasPedidosFechadosPedidos)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK_Vendas_Pedidos_Fechados_Pedidos_Vendas_Pedidos");

                entity.HasOne(d => d.IdPedidoFechadoNavigation)
                    .WithMany(p => p.VendasPedidosFechadosPedidos)
                    .HasForeignKey(d => d.IdPedidoFechado)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vendas_Pedidos_Fechados_Pedidos_Vendas_Pedidos_Fechados");
            });

            modelBuilder.Entity<VendasPedidosFechadosPedidosIten>(entity =>
            {
                entity.ToTable("Vendas_Pedidos_Fechados_Pedidos_Itens");

                entity.HasIndex(e => e.IdVendasPedidosItem, "_dta_index_Vendas_Pedidos_Fechados_Pedidos__9_1463012293__K2_7");

                entity.HasIndex(e => new { e.IdPedidoFechado, e.IdProduto }, "_dta_index_Vendas_Pedidos_Fechados_Pedidos__9_1463012293__K3_K5");

                entity.Property(e => e.Conferido).HasDefaultValueSql("((0))");

                entity.Property(e => e.DataConferencia)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Conferencia");

                entity.Property(e => e.IdConferente).HasColumnName("Id_Conferente");

                entity.Property(e => e.IdCor).HasColumnName("Id_Cor");

                entity.Property(e => e.IdPedidoFechado).HasColumnName("Id_Pedido_Fechado");

                entity.Property(e => e.IdPedidoFechadoPedido).HasColumnName("Id_Pedido_Fechado_Pedido");

                entity.Property(e => e.IdProduto).HasColumnName("Id_Produto");

                entity.Property(e => e.IdVendasPedidosItem).HasColumnName("Id_Vendas_Pedidos_Item");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdConferenteNavigation)
                    .WithMany(p => p.VendasPedidosFechadosPedidosItens)
                    .HasForeignKey(d => d.IdConferente)
                    .HasConstraintName("FK_Vendas_Pedidos_Fechados_Pedidos_Itens_Funcionarios");

                entity.HasOne(d => d.IdCorNavigation)
                    .WithMany(p => p.VendasPedidosFechadosPedidosItens)
                    .HasForeignKey(d => d.IdCor)
                    .HasConstraintName("FK_Fatura_Itens_Cores");

                entity.HasOne(d => d.IdPedidoFechadoNavigation)
                    .WithMany(p => p.VendasPedidosFechadosPedidosItens)
                    .HasForeignKey(d => d.IdPedidoFechado)
                    .HasConstraintName("FK_Fatura_Itens_Faturas");

                entity.HasOne(d => d.IdPedidoFechadoPedidoNavigation)
                    .WithMany(p => p.VendasPedidosFechadosPedidosItens)
                    .HasForeignKey(d => d.IdPedidoFechadoPedido)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vendas_Pedidos_Fechados_Pedidos_Itens_Vendas_Pedidos_Fechados_Pedidos");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.VendasPedidosFechadosPedidosItens)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_Fatura_Itens_Produtos");

                entity.HasOne(d => d.IdVendasPedidosItemNavigation)
                    .WithMany(p => p.VendasPedidosFechadosPedidosItens)
                    .HasForeignKey(d => d.IdVendasPedidosItem)
                    .HasConstraintName("FK_Vendas_Pedidos_Fechados_Pedidos_Itens_Vendas_Pedidos_Itens");
            });

            modelBuilder.Entity<VendasPedidosIten>(entity =>
            {
                entity.ToTable("Vendas_Pedidos_Itens");

                entity.HasIndex(e => e.IdCor, "IX_Vendas_Pedidos_Itens_Id_Cor");

                entity.HasIndex(e => e.IdPedido, "_dta_index_Vendas_Pedidos_Itens_9_1656601190__K2_3");

                entity.Property(e => e.Faturado).HasComputedColumnSql("([dbo].[ItemFaturado]([Qtda],[Qtda_Faturado]))", false);

                entity.Property(e => e.IdCor).HasColumnName("Id_Cor");

                entity.Property(e => e.IdPedido).HasColumnName("Id_Pedido");

                entity.Property(e => e.IdProduto).HasColumnName("Id_Produto");

                entity.Property(e => e.IdStatus).HasColumnName("Id_Status");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Produzido).HasColumnType("datetime");

                entity.Property(e => e.Qtda).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtdaFaturado)
                    .HasColumnName("Qtda_Faturado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtdaProduzido)
                    .HasColumnName("Qtda_Produzido")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Total).HasComputedColumnSql("([Qtda]*[Valor])", false);

                entity.Property(e => e.UltDataProducao)
                    .HasColumnType("datetime")
                    .HasColumnName("Ult_Data_Producao");

                entity.Property(e => e.Urgente).HasDefaultValueSql("((0))");

                entity.Property(e => e.Valor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<VwCep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCEP");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.CepCidade)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CepLogradouro)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(143)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
