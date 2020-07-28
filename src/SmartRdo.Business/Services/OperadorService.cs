using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;

namespace SmartRdo.Business.Services
{
    public class OperadorService : BaseService, IOperadoresService
    {
        private readonly IOperadorRepository _operadorRepository;

        public OperadorService(INotificador notificador,  IOperadorRepository operadorRepository) 
            : base(notificador)
        {
            _operadorRepository = operadorRepository;
        }


        public async Task Adicione(Operador atividade)
        {
            throw new NotImplementedException();
        }

        public async Task Atualize(Operador atividade)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Operador>> ObterTodos()
        {
            return await _operadorRepository.ObterTodos();
        }

        public async Task<Operador> Consultar(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}