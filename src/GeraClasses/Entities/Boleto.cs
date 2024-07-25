using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Boleto
    {
        public int Id { get; set; }
        public int? IdRemessa { get; set; }
        public int? IdNota { get; set; }
        public int? IdConta { get; set; }
        public string B001001 { get; set; }
        public string B002006 { get; set; }
        public string B007007 { get; set; }
        public string B008012 { get; set; }
        public string B013019 { get; set; }
        public string B020020 { get; set; }
        public string B021037 { get; set; }
        public string B038062 { get; set; }
        public string B063065 { get; set; }
        public string B066070 { get; set; }
        public string B071081 { get; set; }
        public string B082082 { get; set; }
        public string B083092 { get; set; }
        public string B093093 { get; set; }
        public string B094094 { get; set; }
        public string B095104 { get; set; }
        public string B105105 { get; set; }
        public string B106106 { get; set; }
        public string B107108 { get; set; }
        public string B109110 { get; set; }
        public string B111120 { get; set; }
        public string B121126 { get; set; }
        public string B127139 { get; set; }
        public string B140142 { get; set; }
        public string B143147 { get; set; }
        public string B148149 { get; set; }
        public string B150150 { get; set; }
        public string B151156 { get; set; }
        public string B157158 { get; set; }
        public string B159160 { get; set; }
        public string B161173 { get; set; }
        public string B174179 { get; set; }
        public string B180192 { get; set; }
        public string B193205 { get; set; }
        public string B206218 { get; set; }
        public string B219220 { get; set; }
        public string B221234 { get; set; }
        public string B235274 { get; set; }
        public string B275314 { get; set; }
        public string B315326 { get; set; }
        public string B327331 { get; set; }
        public string B332334 { get; set; }
        public string B335394 { get; set; }
        public string B395400 { get; set; }
        public bool? GeradoArquivo { get; set; }
        public bool? Impresso { get; set; }
        public bool? Consertar { get; set; }
        public int? IdRemessaAnt { get; set; }
        public bool? Reimprimir { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Conta IdContaNavigation { get; set; }
        public virtual Nf IdNotaNavigation { get; set; }
        public virtual Remessa IdRemessaNavigation { get; set; }
    }
}
