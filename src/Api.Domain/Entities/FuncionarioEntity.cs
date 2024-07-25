using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities {
    [Table("Funcionarios")]
    public class FuncionarioEntity : BaseEntity {

        public FuncionarioEntity()
        {
            //FuncionariosFabricas = new HashSet<FuncionariosFabrica>();
            //Producaos = new HashSet<Producao>();
            Usuarios = new HashSet<UsuarioEntity>();
            //VendasPedidosFechadosAlerta = new HashSet<VendasPedidosFechadosAlerta>();
            //VendasPedidosFechadosPedidosItens = new HashSet<VendasPedidosFechadosPedidosIten>();
        }

        #region ChavesEstrangeiras
        public int? IdSetor { get; set; }
        public int? IdDepartamento { get; set; }
        #endregion

        #region Colunas
        public string Cargo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Ramal { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool? Requisitante { get; set; }
        public bool? Bloqueado { get; set; }
        public string ContatoTipo { get; set; }
        public string ContatoId { get; set; }
        public bool? Usuario { get; set; }
        public bool? Coordenadora { get; set; }
        public bool? BtnTotal { get; set; }
        public bool? BtnAdicionar { get; set; }
        public bool? BtnPedido { get; set; }
        public int? IdFuncionarioProducao { get; set; }
        public bool? EmailPedidoFechado { get; set; }
        public bool? EmailLote { get; set; }
        public bool? EmailMaquinas { get; set; }
        public bool? EmailPedidoRelVendas { get; set; }
        #endregion

        #region Virtual
        public virtual DepartamentoEntity Departamento { get; set; }
        public virtual SetorEntity Setor { get; set; }
        public virtual IEnumerable<FuncionariosFabricaEntity> FuncionariosFabricas { get; set; }
        //public virtual IEnumerable<Producao> Producaos { get; set; }
        public virtual IEnumerable<UsuarioEntity> Usuarios { get; set; }
        //public virtual IEnumerable<VendasPedidosFechadosAlerta> VendasPedidosFechadosAlerta { get; set; }
        //public virtual IEnumerable<VendasPedidosFechadosPedidosIten> VendasPedidosFechadosPedidosItens { get; set; }
        #endregion

    }
}
