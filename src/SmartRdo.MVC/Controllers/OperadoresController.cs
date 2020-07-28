using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;

namespace SmartRdo.MVC.Controllers
{
    public class OperadoresController : Controller
    {
        private readonly IOperadoresService _operadoresService;

        public OperadoresController(IOperadoresService operadoresService)
        {
            _operadoresService = operadoresService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _operadoresService.ObterTodos());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _operadoresService.Consultar(id);

            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Id")] Operador operador)
        {
            if (ModelState.IsValid)
            {
                operador.Id = Guid.NewGuid();
                await _operadoresService.Adicione(operador);
                return RedirectToAction(nameof(Index));
            }
            return View(operador);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _operadoresService.Consultar(id);

            if (operador == null)
            {
                return NotFound();
            }
            return View(operador);
        }

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
                    await _operadoresService.Atualize(operador);
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

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _operadoresService.Consultar(id);

            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _operadoresService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        private bool OperadorExists(Guid id)
        {
            return _operadoresService.Consultar(id) != null;
        }
    }
}
