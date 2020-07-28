using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;

namespace SmartRdo.Business.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        public ClienteService(INotificador notificador) : base(notificador)
        {
        }


        public async Task Adicione(Cliente atividade)
        {
            throw new NotImplementedException();
        }

        public async Task Atualize(Cliente atividade)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cliente>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<Cliente> Consultar(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}