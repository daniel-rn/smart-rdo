using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;

namespace SmartRdo.MVC.Controllers
{
    public class EquipamentosController : MainController
    {
        private readonly IEquipamentoRepository _equipamentoRepository;
        private readonly IEquipamentoService _equipamentoService;

        public EquipamentosController(IEquipamentoRepository equipamentoRepository,
                                        IToastNotification toastNotification,
                                        INotificador notificador,
                                        IEquipamentoService equipamentoService) : base(notificador, toastNotification)
        {
            _equipamentoRepository = equipamentoRepository;
            _equipamentoService = equipamentoService;
        }

        public override async Task<IActionResult> Index()
        {
            return View(await _equipamentoRepository.ObterTodos());
        }

        public async Task<IActionResult> Details(Guid id)
        {
            return await ObterEquipamentoComItenChescklist(id);
        }               

        public IActionResult Create()
        {
            var equipamento = new Equipamento();
            equipamento.ItensChecklist.Add(new ItemChecklistEquipamento());
            return View(equipamento);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Equipamento equipamento)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _equipamentoService.Adicione(equipamento);

            return CustomResponse(equipamento);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            return await ObterEquipamentoComItenChescklist(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Id, ItensChecklist")] Equipamento equipamento)
        {
            if (id != equipamento.Id) return NotFound();

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _equipamentoService.Atualize(equipamento);

            return CustomResponse(equipamento);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            return await ObterEquipamentoComItenChescklist(id);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var equipamento = _equipamentoRepository.ObterPorId(id);

            if (equipamento is null) return NotFound();

            await _equipamentoService.Remove(id);

            return CustomResponse(equipamento);
        }

        private async Task<IActionResult> ObterEquipamentoComItenChescklist(Guid id)
        {
            var equipamento = await _equipamentoRepository.ObterPorIdComItensChecklist(id);
            if (equipamento == null) return NotFound();
            return View(equipamento);
        }
    }
}
