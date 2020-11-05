using System;
using System.Collections.Generic;

namespace SA.Models
{
    public partial class Estoque
    {
        public int Code { get; set; }
        public int Quant { get; set; }
        public decimal ValorUnit { get; set; }
    }
}
