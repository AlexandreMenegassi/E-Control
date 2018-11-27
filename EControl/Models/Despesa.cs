using System;
using System.Collections.Generic;

namespace EControl.Models
{
    public partial class Despesa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? Data { get; set; }
        public decimal? Custo { get; set; }

        public Fornecedor IdNavigation { get; set; }
    }
}
