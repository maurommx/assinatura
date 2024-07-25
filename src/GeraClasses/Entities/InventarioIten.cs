using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class InventarioIten
    {
        public int Id { get; set; }
        public int? IdInventario { get; set; }
        public int? IdProduto { get; set; }
        public decimal? Qtda { get; set; }
        public decimal? Valor { get; set; }
    }
}
