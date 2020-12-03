using System;
using System.Collections.Generic;

namespace SA.Models
{
    public partial class Itensdto
    {
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public override string ToString()
        {
            return $"{Quantidade} - {Nome}";
        }
    }
}
