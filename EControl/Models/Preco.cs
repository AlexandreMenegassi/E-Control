using System;
using System.Collections.Generic;

namespace EControl.Models
{
    public partial class Preco
    {
        public int Id { get; set; }
        public int? IdServico { get; set; }
        public decimal? Custo { get; set; }
        public double? Desconto { get; set; }
        public int? IdFuncionario { get; set; }

        public Funcionario IdFuncionarioNavigation { get; set; }
        public Servico IdNavigation { get; set; }
    }
}
