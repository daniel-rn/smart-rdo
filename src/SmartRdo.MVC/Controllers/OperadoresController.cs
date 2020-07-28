using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;

namespace SmartRdo.MVC.Controllers
{
    public class OperadoresController : Controller
    {
        private readonly SmartRdoDbContext _context;

        public OperadoresController(SmartRdoDbContext context)
        {
            _context = context;
        }

        // GET: Operadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Operadores.ToListAsync());
        }

        // GET: Operadores/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _context.Operadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }

        // GET: Operadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Operadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Id")] Operador operador)
        {
            if (ModelState.IsValid)
            {
                operador.Id = Guid.NewGuid();
                _context.Add(operador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(operador);
        }

        // GET: Operadores/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _context.Operadores.FindAsync(id);
            if (operador == null)
            {
                return NotFound();
            }
            return View(operador);
        }

        // POST: Operadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Id")] Operador operador)
        {
            if (id != operador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperadorExists(operador.Id))
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
            return View(operador);
        }

        // GET: Operadores/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _context.Operadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }

        // POST: Operadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var operador = await _context.Operadores.FindAsync(id);
            _context.Operadores.Remove(operador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperadorExists(Guid id)
        {
            return _context.Operadores.Any(e => e.Id == id);
        }
    }
}
