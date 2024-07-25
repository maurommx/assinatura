using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities {
    [Table("Setores")]
    public class SetorEntity : BaseEntity {

        #region ChavesEstrangeiras
        public int? IdDivisao { get; set; }
        public int? IdFabrica { get; set; }
        #endregion

        #region Colunas
        public string Descricao { get; set; }
        #endregion

        #region Virtual
        public virtual DivisaoEntity Divisao { get; set; }
        public virtual FabricaEntity Fabrica { get; set; }
        public virtual IEnumerable<FuncionarioEntity> Funcionarios { get; set; }
        #endregion

    }
}
