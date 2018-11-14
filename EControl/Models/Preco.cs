using System;
using System.Collections.Generic;

namespace EControl.Models
{
    public partial class Preco
    {
        public int Id { get; set; }
        public string ServicoNom { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Custo { get; set; }
        public double? Desconto { get; set; }
        public int? IdFuncionario { get; set; }

        public Funcionario IdFuncionarioNavigation { get; set; }
    }
}
