﻿using System;
using System.Collections.Generic;

namespace SA.Models
{
    public partial class Mesas
    {
        public int Id { get; set; }
        public string Nomemesa { get; set; }
        public string Statusmesa { get; set; }
        public string Statuspedido { get; set; }
        public string Observacao { get; set; }
        public override string ToString()
        {
            return $"{Nomemesa}";
        }
    }
}
