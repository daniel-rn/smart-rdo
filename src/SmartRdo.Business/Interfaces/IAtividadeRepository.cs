using SmartRdo.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRdo.Business.Interfaces
{
    public interface IAtividadeRepository : IRepository<Atividade>
    {
        Task<IEnumerable<Atividade>> ObtenhaAtividadesPorOperador(Guid operadorId);
        Task<IEnumerable<Atividade>> ObtenhaAtividadesOperadores();
        Task<Atividade> ObtenhaAtivdadeOperador(Guid id);
    }
}
