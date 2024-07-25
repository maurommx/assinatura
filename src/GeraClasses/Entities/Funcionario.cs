using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Funcionario
    {
        public Funcionario()
        {
            FuncionariosFabricas = new HashSet<FuncionariosFabrica>();
            Producaos = new HashSet<Producao>();
            Usuarios = new HashSet<Usuario>();
            VendasPedidosFechadosAlerta = new HashSet<VendasPedidosFechadosAlerta>();
            VendasPedidosFechadosPedidosItens = new HashSet<VendasPedidosFechadosPedidosIten>();
        }

        public int Id { get; set; }
        public int? IdSetor { get; set; }
        public int? IdDepartamento { get; set; }
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
        public Guid MsreplTranVersion { get; set; }
        public bool? EmailPedidoFechado { get; set; }
        public bool? EmailLote { get; set; }
        public bool? EmailMaquinas { get; set; }
        public bool? EmailPedidoRelVendas { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; }
        public virtual Setore IdSetorNavigation { get; set; }
        public virtual ICollection<FuncionariosFabrica> FuncionariosFabricas { get; set; }
        public virtual ICollection<Producao> Producaos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<VendasPedidosFechadosAlerta> VendasPedidosFechadosAlerta { get; set; }
        public virtual ICollection<VendasPedidosFechadosPedidosIten> VendasPedidosFechadosPedidosItens { get; set; }
    }
}
