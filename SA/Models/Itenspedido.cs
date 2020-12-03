using System;
using System.Collections.Generic;

namespace SA.Models
{
    public partial class Itenspedido
    {
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public decimal ValorProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal? Total { get; set; }
    }
}
