using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;

namespace SmartRdo.MVC.Controllers
{
    public class AtividadesController : Controller
    {
        private readonly SmartRdoDbContext _context;

        public AtividadesController(SmartRdoDbContext context)
        {
            _context = context;
        }

        // GET: Atividades
        public async Task<IActionResult> Index()
        {
            var smartRdoDbContext = _context.Atividades.Include(a => a.Area).Include(a => a.Cliente).Include(a => a.ResponsavelArea);
            return View(await smartRdoDbContext.ToListAsync());
        }

        // GET: Atividades/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atividade = await _context.Atividades
                .Include(a => a.Area)
                .Include(a => a.Cliente)
                .Include(a => a.ResponsavelArea)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atividade == null)
            {
                return NotFound();
            }

            return View(atividade);
        }

        // GET: Atividades/Create
        public IActionResult Create()
        {
            ViewData["AreaId"] = new SelectList(_context.Areas, "Id", "CodigoArea");
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome");
            ViewData["ResponsavelAreaId"] = new SelectList(_context.Set<ResponsavelArea>(), "Id", "Nome");
            return View();
        }

        // POST: Atividades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Descricao,Inicio,Fim,InicioPrevisto,FimPrevisto,LocalDescarte,ClienteId,AreaId,ResponsavelAreaId,Id")] Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                atividade.Id = Guid.NewGuid();
                _context.Add(atividade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AreaId"] = new SelectList(_context.Areas, "Id", "CodigoArea", atividade.AreaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", atividade.ClienteId);
            ViewData["ResponsavelAreaId"] = new SelectList(_context.Set<ResponsavelArea>(), "Id", "Nome", atividade.ResponsavelAreaId);
            return View(atividade);
        }

        // GET: Atividades/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atividade = await _context.Atividades.FindAsync(id);
            if (atividade == null)
            {
                return NotFound();
            }
            ViewData["AreaId"] = new SelectList(_context.Areas, "Id", "CodigoArea", atividade.AreaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", atividade.ClienteId);
            ViewData["ResponsavelAreaId"] = new SelectList(_context.Set<ResponsavelArea>(), "Id", "Nome", atividade.ResponsavelAreaId);
            return View(atividade);
        }

        // POST: Atividades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Codigo,Descricao,Inicio,Fim,InicioPrevisto,FimPrevisto,LocalDescarte,ClienteId,AreaId,ResponsavelAreaId,Id")] Atividade atividade)
        {
            if (id != atividade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atividade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtividadeExists(atividade.Id))
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
            ViewData["AreaId"] = new SelectList(_context.Areas, "Id", "CodigoArea", atividade.AreaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", atividade.ClienteId);
            ViewData["ResponsavelAreaId"] = new SelectList(_context.Set<ResponsavelArea>(), "Id", "Nome", atividade.ResponsavelAreaId);
            return View(atividade);
        }

        // GET: Atividades/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atividade = await _context.Atividades
                .Include(a => a.Area)
                .Include(a => a.Cliente)
                .Include(a => a.ResponsavelArea)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atividade == null)
            {
                return NotFound();
            }

            return View(atividade);
        }

        // POST: Atividades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var atividade = await _context.Atividades.FindAsync(id);
            _context.Atividades.Remove(atividade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtividadeExists(Guid id)
        {
            return _context.Atividades.Any(e => e.Id == id);
        }
    }
}
