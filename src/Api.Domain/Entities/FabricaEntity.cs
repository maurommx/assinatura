using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities {
    [Table("Fabricas")]
    public class FabricaEntity : BaseEntity {

        #region ChavesEstrangeiras
        public int? IdDivisao { get; set; }
        #endregion

        #region Colunas
        public string Descricao { get; set; }
        public string Resumido { get; set; }
        public int? Limite { get; set; }
        #endregion

        #region Virtual
        public virtual DivisaoEntity Divisao { get; set; }
        public virtual IEnumerable<SetorEntity> Setores { get; set; }
        public virtual IEnumerable<FuncionariosFabricaEntity> FuncionariosFabricas { get; set; }
        #endregion
    }
}
