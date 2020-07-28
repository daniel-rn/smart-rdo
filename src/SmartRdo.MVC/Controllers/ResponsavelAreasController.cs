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
    public class ResponsavelAreasController : Controller
    {
        private readonly IResponsavelAreasService _responsavelAreasService;

        public ResponsavelAreasController(IResponsavelAreasService responsavelAreaService)
        {
            _responsavelAreasService = responsavelAreaService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _responsavelAreasService.ObterTodos());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsavelArea = await _responsavelAreasService.Consultar(id);

            if (responsavelArea == null)
            {
                return NotFound();
            }

            return View(responsavelArea);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ResponsavelArea responsavelArea)
        {
            if (ModelState.IsValid)
            {
                responsavelArea.Id = Guid.NewGuid();
                await _responsavelAreasService.Adicione(responsavelArea);
                return RedirectToAction(nameof(Index));
            }

            return View(responsavelArea);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsavelArea = await _responsavelAreasService.Consultar(id);
            if (responsavelArea == null)
            {
                return NotFound();
            }
            return View(responsavelArea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Id")] ResponsavelArea responsavelArea)
        {
            if (id != responsavelArea.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _responsavelAreasService.Atualize(responsavelArea);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResponsavelAreaExists(responsavelArea.Id))
                    {
                        return NotFound();
                    }

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(responsavelArea);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsavelArea = await _responsavelAreasService.Consultar(id);

            if (responsavelArea == null)
            {
                return NotFound();
            }

            return View(responsavelArea);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _responsavelAreasService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ResponsavelAreaExists(Guid id)
        {
            return _responsavelAreasService.Consultar(id) != null;
        }
    }
}
