using System;
using System.Collections.Generic;

namespace EControl.Models
{
    public partial class Agenda
    {
        public int Id { get; set; }
        public string IdFuncionario { get; set; }
        public string IdServico { get; set; }
        public string IdCliente { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}
