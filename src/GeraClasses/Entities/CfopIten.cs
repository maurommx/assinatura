using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class CfopIten
    {
        public int Id { get; set; }
        public int? IdCfop { get; set; }
        public string Uf { get; set; }
        public double? AliqIcmsCnpj { get; set; }
        public double? RedIcmsCnpj { get; set; }
        public double? AliqIcmsCpf { get; set; }
        public double? RedIcmsCpf { get; set; }
        public string CstCnpj { get; set; }
        public string CstCpf { get; set; }
        public string Obs { get; set; }
        public string CstIpi { get; set; }
        public double? AliqIpi { get; set; }
        public string CstPis { get; set; }
        public double? AliqPis { get; set; }
        public string CstCofins { get; set; }
        public double? AliqCofins { get; set; }
        public bool? Preferencia { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public string CstFci { get; set; }
        public decimal? AliqIcmsFci { get; set; }

        public virtual Cfop IdCfopNavigation { get; set; }
    }
}
