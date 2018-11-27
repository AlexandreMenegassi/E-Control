using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EControl.Models
{
    public partial class Despesa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Data { get; set; }
        public decimal Custo { get; set; }
    }
}
