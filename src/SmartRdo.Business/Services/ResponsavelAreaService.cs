using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;

namespace SmartRdo.Business.Services
{
    public class ResponsavelAreaService : BaseService, IResponsavelAreasService
    {
        private readonly IResponsavelAreaRepository _responsavelAreaRepository;

        public ResponsavelAreaService(INotificador notificador, IResponsavelAreaRepository responsavelAreaRepository) 
            : base(notificador)
        {
            _responsavelAreaRepository = responsavelAreaRepository;
        }

        public async Task Adicione(ResponsavelArea atividade)
        {
            await _responsavelAreaRepository.Adicionar(atividade);
        }

        public async Task Atualize(ResponsavelArea atividade)
        {
            await _responsavelAreaRepository.Atualizar(atividade);
        }

        public async Task Remove(Guid id)
        {
            await _responsavelAreaRepository.Remover(id);
        }

        public async Task<List<ResponsavelArea>> ObterTodos()
        {
            return await _responsavelAreaRepository.ObterTodos();
        }

        public async Task<ResponsavelArea> Consultar(Guid? id)
        {
            return await _responsavelAreaRepository.ObterPorId(id.Value);
        }
    }
}