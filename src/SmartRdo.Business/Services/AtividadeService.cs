using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Models;
using SmartRdo.Business.Models.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Interfaces.services;

namespace SmartRdo.Business.Services
{
    public class AtividadeService : BaseService, IAtividadeService
    {
        private readonly IAtividadeRepository _atividadeRepository;
        
        public AtividadeService(INotificador notificador, IAtividadeRepository atividadeRepository) 
            : base(notificador)
        {
            _atividadeRepository = atividadeRepository;
        }

        public async Task Adicione(Atividade atividade)
        {
            if (!ExecutarValidacao(new AtividadeValidation(), atividade)) return;

             await _atividadeRepository.Adicionar(atividade);
        }

        public Task Atualize(Atividade produto)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid id)
        {
            return _atividadeRepository.Remover(id);
        }

        public async Task<List<Atividade>> ObterTodos()
        {
            return await _atividadeRepository.ObterTodos();
        }

        public async Task<Atividade> Consultar(Guid? id)
        {
            return await _atividadeRepository.Consultar(id);
        }

        public void Dispose()
        {
            _atividadeRepository?.Dispose();
        }

    }
}
