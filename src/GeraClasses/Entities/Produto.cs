using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Produto
    {
        public Produto()
        {
            ClientesProdutosDescontos = new HashSet<ClientesProdutosDesconto>();
            NfCanceladasItens = new HashSet<NfCanceladasIten>();
            Producaos = new HashSet<Producao>();
            RepresentantesProdutosDescontos = new HashSet<RepresentantesProdutosDesconto>();
            TabelaPrecoProdutos = new HashSet<TabelaPrecoProduto>();
            VendasPedidosFechadosPedidosItens = new HashSet<VendasPedidosFechadosPedidosIten>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string DescricaoReduzido { get; set; }
        public int? IdUnidade { get; set; }
        public int? IdFabrica { get; set; }
        public decimal? Peso { get; set; }
        public double? PesoPorcentagem { get; set; }
        public double? QuantidadeVolume { get; set; }
        public double? QuantidadeEmbalagem { get; set; }
        public int? IdClassificacao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool? Bloqueado { get; set; }
        public double? Ipi { get; set; }
        public double? SubstTributaria { get; set; }
        public int? IdTitulo { get; set; }
        public string IdProducao { get; set; }
        public bool? Preto { get; set; }
        public bool? Branco { get; set; }
        public bool? AceitaPreto { get; set; }
        public bool? AceitaBranco { get; set; }
        public string Fci { get; set; }
        public decimal? FciPercentual { get; set; }
        public DateTime? FciAtualizacao { get; set; }
        public int? Origem { get; set; }
        public bool? Programar { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public decimal? PesoFioTinto { get; set; }
        public int? LimiteDiarioPeso { get; set; }
        public bool? ProgramarMinMeiaCaixa { get; set; }
        public bool? ProgramarMinUmaCaixa { get; set; }
        public bool? BloqueadoProducao { get; set; }
        public int? OrdemTabela { get; set; }
        public bool? BloqueadoVenda { get; set; }
        public string Gtin { get; set; }

        public virtual ClassificacaoFiscal IdClassificacaoNavigation { get; set; }
        public virtual Fabrica IdFabricaNavigation { get; set; }
        public virtual Unidade IdUnidadeNavigation { get; set; }
        public virtual ICollection<ClientesProdutosDesconto> ClientesProdutosDescontos { get; set; }
        public virtual ICollection<NfCanceladasIten> NfCanceladasItens { get; set; }
        public virtual ICollection<Producao> Producaos { get; set; }
        public virtual ICollection<RepresentantesProdutosDesconto> RepresentantesProdutosDescontos { get; set; }
        public virtual ICollection<TabelaPrecoProduto> TabelaPrecoProdutos { get; set; }
        public virtual ICollection<VendasPedidosFechadosPedidosIten> VendasPedidosFechadosPedidosItens { get; set; }
    }
}
