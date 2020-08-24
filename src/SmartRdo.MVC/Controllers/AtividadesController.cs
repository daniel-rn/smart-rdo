using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;

namespace SmartRdo.MVC.Controllers
{
    [Authorize]
    public class AtividadesController : Controller
    {
        private readonly IAtividadeService _atividadeService;
        private readonly IAreasService _areasService;
        private readonly IClienteService _clienteService;
        private readonly IOperadoresService _operadoresService;
        private readonly IResponsavelAreasService _responsavelAreasService;

        public AtividadesController(IAtividadeService atividadeService,
            IAreasService areasService,
            IClienteService clienteService,
            IOperadoresService operadoresService,
            IResponsavelAreasService responsavelAreasService)
        {
            _atividadeService = atividadeService;
            _areasService = areasService;
            _clienteService = clienteService;
            _operadoresService = operadoresService;
            _responsavelAreasService = responsavelAreasService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _atividadeService.ObterTodos());
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var atividade = await _atividadeService.Consultar(id);

            if (atividade == null)
            {
                return NotFound();
            }

            return View(atividade);
        }

        public async Task<ViewResult> Create()
        {
            ViewData["AreaId"] = new SelectList(await _areasService.ObterTodos(), "Id", "CodigoArea");
            ViewData["ClienteId"] = new SelectList(await _clienteService.ObterTodos(), "Id", "Nome");
            ViewData["OperadorId"] = new SelectList(await _operadoresService.ObterTodos(), "Id", "Nome");
            ViewData["ResponsavelAreaId"] = new SelectList(await _responsavelAreasService.ObterTodos(), "Id", "Nome");

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

            ViewData["AreaId"] = new SelectList(await _areasService.ObterTodos(), "Id", "CodigoArea", atividade.AreaId);
            ViewData["ClienteId"] = new SelectList(await _clienteService.ObterTodos(), "Id", "Nome", atividade.ClienteId);
            ViewData["OperadorId"] = new SelectList(await _operadoresService.ObterTodos(), "Id", "Nome", atividade.OperadorId);
            ViewData["ResponsavelAreaId"] = new SelectList(await _responsavelAreasService.ObterTodos(), "Id", "Nome", atividade.ResponsavelAreaId);

            return View(atividade);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var atividade = await _atividadeService.Consultar(id);

            if (atividade == null)
            {
                return NotFound();
            }

            ViewData["AreaId"] = new SelectList(await _areasService.ObterTodos(), "Id", "CodigoArea", atividade.AreaId);
            ViewData["ClienteId"] = new SelectList(await _clienteService.ObterTodos(), "Id", "Nome", atividade.ClienteId);
            ViewData["OperadorId"] = new SelectList(await _operadoresService.ObterTodos(), "Id", "Nome", atividade.OperadorId);
            ViewData["ResponsavelAreaId"] = new SelectList(await _responsavelAreasService.ObterTodos(), "Id", "Nome", atividade.ResponsavelAreaId);

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
                    await _atividadeService.Atualize(atividade);
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

            ViewData["AreaId"] = new SelectList(await _areasService.ObterTodos(), "Id", "CodigoArea", atividade.AreaId);
            ViewData["ClienteId"] = new SelectList(await _clienteService.ObterTodos(), "Id", "Nome", atividade.ClienteId);
            ViewData["OperadorId"] = new SelectList(await _operadoresService.ObterTodos(), "Id", "Nome", atividade.OperadorId);
            ViewData["ResponsavelAreaId"] = new SelectList(await _responsavelAreasService.ObterTodos(), "Id", "Nome", atividade.ResponsavelAreaId);

            return View(atividade);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
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
            return _atividadeService.Consultar(id) != null;
        }
    }
}
