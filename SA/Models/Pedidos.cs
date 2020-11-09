using System;
using System.Collections.Generic;

namespace SA.Models
{
    public partial class Pedidos
    {
        public int Id { get; set; }
        public int Nmesa { get; set; }
        public decimal Valor { get; set; }
        public string Observacoes { get; set; }
    }
}
