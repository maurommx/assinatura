using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities {
    [Table("FuncionariosFabricas")]
    public class FuncionariosFabricaEntity : BaseEntity {
        #region ChavesEstrangeiras
        public int IdFuncionario { get; set; }
        public int IdFabrica { get; set; }
        #endregion

        #region Virtual
        public virtual FabricaEntity Fabrica { get; set; }
        public virtual FuncionarioEntity Funcionario { get; set; }
        #endregion
    }
}
