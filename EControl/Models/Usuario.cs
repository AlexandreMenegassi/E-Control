using System;
using System.Collections.Generic;

namespace EControl.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Administrador = new HashSet<Administrador>();
            Cliente = new HashSet<Cliente>();
            Funcionario = new HashSet<Funcionario>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? NivelDeAcesso { get; set; }

        public ICollection<Administrador> Administrador { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Funcionario> Funcionario { get; set; }
    }
}
