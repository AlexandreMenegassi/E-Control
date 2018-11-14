using System;
using System.Collections.Generic;

namespace EControl.Models
{
    public partial class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Custo { get; set; }
        public double? Desconto { get; set; }
        public string TipoPag { get; set; }
    }
}
