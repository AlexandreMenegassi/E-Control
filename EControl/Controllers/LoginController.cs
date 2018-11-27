using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using EControl.Utils;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EControl.Controllers
{
    public class LoginController : Controller
    {
        private readonly EcontrolContext _context;

        public LoginController(EcontrolContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario = _context.Usuario.Where(u => u.Login == usuario.Login && u.Password == usuario.Password).FirstOrDefault();

                if (usuario != null)
                {
                    HttpContext.Session.SetObject("Usuario", usuario);
                    HttpContext.Session.SetInt32("Usuario.NivelDeAcesso", usuario.NivelDeAcesso ?? 0);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}
