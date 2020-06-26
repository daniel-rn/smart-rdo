using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Models;
using SmartRdo.Business.Models.Validacoes;
using System;
using System.Threading.Tasks;

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

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
            _atividadeRepository?.Dispose();
        }

    }
}
