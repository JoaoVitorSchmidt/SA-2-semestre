using System;
using System.Collections.Generic;

namespace SA.Models
{
    public partial class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome}, {Valor}";
        }
    }
}
