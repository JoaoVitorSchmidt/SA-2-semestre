using System;
using System.Collections.Generic;

namespace SA.Models
{
    public partial class Pedidos
    {
        public int Id { get; set; }
        public DateTime Datapedido { get; set; }
        public ulong? Pago { get; set; }
    }
}
