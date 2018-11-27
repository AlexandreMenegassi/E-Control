using System;
using System.Collections.Generic;

namespace EControl.Models
{
    public partial class Servico
    {
        public Servico()
        {
            Preco = new HashSet<Preco>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Custo { get; set; }

        public ICollection<Preco> Preco { get; set; }
    }
}
