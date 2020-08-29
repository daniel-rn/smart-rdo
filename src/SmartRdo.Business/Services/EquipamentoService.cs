using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Models;
using SmartRdo.Business.Models.Validacoes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Interfaces.services;

namespace SmartRdo.Business.Services
{
    public class EquipamentoService : BaseService, IEquipamentoService
    {
        private readonly IEquipamentoRepository _equipamentoRepository;

        public EquipamentoService(INotificador notificador, IEquipamentoRepository equipamentoRepository)
            : base(notificador)
        {
            _equipamentoRepository = equipamentoRepository;
        }

        public async Task Adicione(Equipamento equipamento)
        {
            equipamento.ItensChecklist.RemoveAll(i => string.IsNullOrWhiteSpace(i.Descricao));

            if (!ExecutarValidacao(new EquipamentoValidation(), equipamento)) return;

            await _equipamentoRepository.Adicionar(equipamento);
        }

        public async Task Atualize(Equipamento equipamento)
        {
            equipamento.ItensChecklist.RemoveAll(i => string.IsNullOrWhiteSpace(i.Descricao));
            equipamento.ItensChecklist.ForEach(i => i.IdEquipamento = equipamento.Id);

            if (!ExecutarValidacao(new EquipamentoValidation(), equipamento)) return;

            await _equipamentoRepository.Atualizar(equipamento);
        }

        public Task<Equipamento> Consultar(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Equipamento>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public async Task Remove(Guid id)
        {
            await _equipamentoRepository.Remover(id);
        }
    }
}
