using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EControl.Models
{
    public partial class Administrador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sexo { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Nascimento { get; set; }
        public string TelefoneCel { get; set; }
        public string TelefoneRes { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public int? IdUsuario { get; set; }

        public Usuario IdUsuarioNavigation { get; set; }
    }
}
