using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Insumo
    {
        public Insumo()
        {
            NfCanceladasItens = new HashSet<NfCanceladasIten>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Modelo { get; set; }
        public int? IdUnidade { get; set; }
        public decimal? Preco { get; set; }
        public string Caracteristicas { get; set; }
        public string Finalidade { get; set; }
        public double? QuantidadeEmbalado { get; set; }
        public double? QuantidadeVolume { get; set; }
        public DateTime? UltimaCompra { get; set; }
        public decimal? PrecoAnterior { get; set; }
        public int? IdGrupo { get; set; }
        public int? IdTipo { get; set; }
        public double? QuantidadeEstoque { get; set; }
        public string Ncm { get; set; }
        public string Gtin { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public decimal? Estoque { get; set; }

        public virtual MateriaisGrupo IdGrupoNavigation { get; set; }
        public virtual MateriaisTipo IdTipoNavigation { get; set; }
        public virtual Unidade IdUnidadeNavigation { get; set; }
        public virtual ICollection<NfCanceladasIten> NfCanceladasItens { get; set; }
    }
}
