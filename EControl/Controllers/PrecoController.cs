using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EControl.Models;

namespace EControl.Controllers
{
    public class PrecoController : Controller
    {
        private readonly EcontrolContext _context;

        public PrecoController(EcontrolContext context)
                            
        {
            _context = context;
        }

        // GET: Preco
        public async Task<IActionResult> Index()
        {
            var eControlContext = _context.Preco
                .Include(p => p.IdFuncionarioNavigation)
                .Include(p => p.IdServicoNavigation);
            return View(await eControlContext.ToListAsync());
        }

        // GET: Preco/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preco = await _context.Preco
                .Include(p => p.IdFuncionarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preco == null)
            {
                return NotFound();
            }

            return View(preco);
        }

        // GET: Preco/Create
        public IActionResult Create()
        {
            ViewData["IdFuncionario"] = new SelectList(_context.Funcionario, "Id", "Nome");
            ViewData["IdServico"] = new SelectList(_context.Servico, "Id", "Nome");
            return View();
        }

        // POST: Preco/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Preco preco)
        {
            if (ModelState.IsValid)
            {
                decimal? custo = _context.Servico.Where(a => a.Id == preco.IdServico).Select(a => a.Valor).FirstOrDefault();
                preco.Custo = custo;
                _context.Add(preco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdFuncionario"] = new SelectList(_context.Funcionario, "Id", "Id", preco.IdFuncionario);
            return View(preco);
        }

        // GET: Preco/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preco = await _context.Preco.FindAsync(id);
            if (preco == null)
            {
                return NotFound();
            }
            ViewData["IdFuncionario"] = new SelectList(_context.Funcionario, "Id", "Id", preco.IdFuncionario);
            return View(preco);
        }

        // POST: Preco/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ServicoNom,Valor,Custo,Desconto,IdFuncionario")] Preco preco)
        {
            if (id != preco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrecoExists(preco.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdFuncionario"] = new SelectList(_context.Funcionario, "Id", "Id", preco.IdFuncionario);
            return View(preco);
        }

        // GET: Preco/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preco = await _context.Preco
                .Include(p => p.IdFuncionarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preco == null)
            {
                return NotFound();
            }

            return View(preco);
        }

        // POST: Preco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var preco = await _context.Preco.FindAsync(id);
            _context.Preco.Remove(preco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrecoExists(int id)
        {
            return _context.Preco.Any(e => e.Id == id);
        }
    }
}
