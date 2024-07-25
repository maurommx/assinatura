using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities {
    [Table("Departamentos")]
    public class DepartamentoEntity : BaseEntity {

        #region Colunas
        public int? IdSetor { get; set; }
        public string Descricao { get; set; }
        #endregion

        #region Virtual
        public virtual IEnumerable<FuncionarioEntity> Funcionarios { get; set; }
        #endregion
    }
}
