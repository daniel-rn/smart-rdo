using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;

namespace SmartRdo.Business.Services
{
    public class AreasService : BaseService, IAreasService
    {
        public AreasService(INotificador notificador) : base(notificador)
        {
        }


        public async Task Adicione(Area atividade)
        {
            throw new NotImplementedException();
        }

        public async Task Atualize(Area atividade)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Area>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<Area> Consultar(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}