using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;

namespace SmartRdo.MVC.Controllers
{
    public class AtividadesController : Controller
    {
        private readonly SmartRdoDbContext _context;
        private readonly IAtividadeService _atividadeService;

        public AtividadesController(SmartRdoDbContext context, IAtividadeService atividadeService)
        {
            _context = context;
            _atividadeService = atividadeService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _atividadeService.ObterTodos());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atividade = await _atividadeService.Consultar(id);

            if (atividade == null)
            {
                return NotFound();
            }

            return View(atividade);
        }

        public IActionResult Create()
        {
            ViewData["AreaId"] = new SelectList(_context.Areas, "Id", "CodigoArea");
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome");
            ViewData["OperadorId"] = new SelectList(_context.Operadores, "Id", "Nome");
            ViewData["ResponsavelAreaId"] = new SelectList(_context.ResponsavelAreas, "Id", "Nome");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                await _atividadeService.Adicione(atividade);
                return RedirectToAction(nameof(Index));
            }

            ViewData["AreaId"] = new SelectList(_context.Areas, "Id", "CodigoArea", atividade.AreaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", atividade.ClienteId);
            ViewData["OperadorId"] = new SelectList(_context.Operadores, "Id", "Nome", atividade.OperadorId);
            ViewData["ResponsavelAreaId"] = new SelectList(_context.ResponsavelAreas, "Id", "Nome", atividade.ResponsavelAreaId);
            
            return View(atividade);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atividade = await _atividadeService.Consultar(id);

            if (atividade == null)
            {
                return NotFound();
            }

            ViewData["AreaId"] = new SelectList(_context.Areas, "Id", "CodigoArea", atividade.AreaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", atividade.ClienteId);
            ViewData["OperadorId"] = new SelectList(_context.Operadores, "Id", "Nome", atividade.OperadorId);
            ViewData["ResponsavelAreaId"] = new SelectList(_context.ResponsavelAreas, "Id", "Nome", atividade.ResponsavelAreaId);

            return View(atividade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Atividade atividade)
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

                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["AreaId"] = new SelectList(_context.Areas, "Id", "CodigoArea", atividade.AreaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", atividade.ClienteId);
            ViewData["OperadorId"] = new SelectList(_context.Operadores, "Id", "Nome", atividade.OperadorId);
            ViewData["ResponsavelAreaId"] = new SelectList(_context.ResponsavelAreas, "Id", "Nome", atividade.ResponsavelAreaId);

            return View(atividade);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atividade = await _atividadeService.Consultar(id);
            
            if (atividade == null)
            {
                return NotFound();
            }

            return View(atividade);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _atividadeService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        private bool AtividadeExists(Guid id)
        {
            return _context.Atividades.Any(e => e.Id == id);
        }
    }
}
