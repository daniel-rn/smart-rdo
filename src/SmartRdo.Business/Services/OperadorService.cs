using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;

namespace SmartRdo.Business.Services
{
    public class OperadorService : BaseService, IOperadoresService
    {
        public OperadorService(INotificador notificador) : base(notificador)
        {
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
            throw new NotImplementedException();
        }

        public async Task<Operador> Consultar(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}