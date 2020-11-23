using System;
using System.Collections.Generic;

namespace SA.Models
{
    public partial class Estoque
    {
        public int Id { get; set; }
        public string Identificacao { get; set; }
        public decimal ValorKg { get; set; }
        public decimal QuantidadeKg { get; set; }
        public decimal? ValorTotal { get; set; }
    }
}
