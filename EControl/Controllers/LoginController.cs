using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EControl.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EControl.Controllers
{
    public class LoginController : Controller
    {
        private readonly EControlContext _context;

        public LoginController(EControlContext context)
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
        public async Task<IActionResult> Login(UsuarioLogin us)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(us);
                //await _context.SaveChangesAsync();

                if (us.Nome == "admin@admin" && us.Senha == "123456")
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(us);
        }
    }
}
