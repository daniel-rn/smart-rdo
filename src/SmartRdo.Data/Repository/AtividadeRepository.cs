using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRdo.Data.Repository
{
    public class AtividadeRepository : Repository<Atividade>, IAtividadeRepository
    {
        public AtividadeRepository(SmartRdoDbContext db) : base(db){ }

        public Task<Atividade> ObtenhaAtivdadeOperador(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Atividade>> ObtenhaAtividadesOperadores()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Atividade>> ObtenhaAtividadesPorOperador(Guid operadorId)
        {
            throw new NotImplementedException();
        }
    }
}
