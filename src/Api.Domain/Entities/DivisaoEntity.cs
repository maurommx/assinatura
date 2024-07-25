using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities {
    [Table("Divisoes")]
    public class DivisaoEntity : BaseEntity {

        #region Colunas
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal? Cota { get; set; }
        #endregion

        #region Virtual
        public virtual IEnumerable<FabricaEntity> Fabricas { get; set; }
        public virtual IEnumerable<SetorEntity> Setores { get; set; }
        #endregion

    }
}
