using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;

namespace SmartRdo.Business.Services
{
    public class ResponsavelAreaService : BaseService, IResponsavelAreasService
    {
        public ResponsavelAreaService(INotificador notificador) : base(notificador)
        {
        }


        public async Task Adicione(ResponsavelArea atividade)
        {
            throw new NotImplementedException();
        }

        public async Task Atualize(ResponsavelArea atividade)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResponsavelArea>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponsavelArea> Consultar(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}