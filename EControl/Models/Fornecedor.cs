using System;
using System.Collections.Generic;

namespace EControl.Models
{
    public partial class Fornecedor
    {
        public int Id { get; set; }
        public string NomeEmp { get; set; }
        public string NomeRep { get; set; }
        public string Cnpj { get; set; }
        public string TelefoneCom1 { get; set; }
        public string TelefoneCom2 { get; set; }
        public string TelefoneCel1 { get; set; }
        public string TelefoneCel2 { get; set; }
        public string Endereco { get; set; }
        public string DescricaoEmp { get; set; }
    }
}
