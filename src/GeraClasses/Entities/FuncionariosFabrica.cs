using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class FuncionariosFabrica
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public int IdFabrica { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual Fabrica IdFabricaNavigation { get; set; }
        public virtual Funcionario IdFuncionarioNavigation { get; set; }
    }
}
