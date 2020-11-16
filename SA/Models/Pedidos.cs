using System;
using System.Collections.Generic;

namespace SA.Models
{
    public partial class Pedidos
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }
    }
}
