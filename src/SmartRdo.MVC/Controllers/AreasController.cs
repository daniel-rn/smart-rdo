using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;

namespace SmartRdo.MVC.Controllers
{
    
    public class AreasController : Controller
    {
        private readonly IAreasService _areasService;

        public AreasController(SmartRdoDbContext context, IAreasService areasService)
        {
            _areasService = areasService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _areasService.ObterTodos());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var area = await _areasService.Consultar(id);
            
            if (area == null)
            {
                return NotFound();
            }

            return View(area);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,CodigoArea,Id")] Area area)
        {
            if (ModelState.IsValid)
            {
                area.Id = Guid.NewGuid();
                await _areasService.Adicione(area);
                return RedirectToAction(nameof(Index));
            }
            return View(area);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var area = await _areasService.Consultar(id);
            if (area == null)
            {
                return NotFound();
            }
            return View(area);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,CodigoArea,Id")] Area area)
        {
            if (id != area.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _areasService.Atualize(area);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AreaExists(area.Id))
                    {
                        return NotFound();
                    }

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(area);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var area = await _areasService.Consultar(id);
            if (area == null)
            {
                return NotFound();
            }

            return View(area);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _areasService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        private bool AreaExists(Guid id)
        {
            return _areasService.Consultar(id) != null;
        }
    }
}
