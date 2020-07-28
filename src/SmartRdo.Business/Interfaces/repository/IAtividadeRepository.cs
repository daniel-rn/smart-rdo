using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartRdo.Business.Models;

namespace SmartRdo.Business.Interfaces.repository
{
    public interface IAtividadeRepository : IRepository<Atividade>
    {
        Task<IEnumerable<Atividade>> ObtenhaAtividadesPorOperador(Guid operadorId);
        Task<IEnumerable<Atividade>> ObtenhaAtividadesOperadores();
        Task<Atividade> ObtenhaAtivdadeOperador(Guid id);
        Task<Atividade> Consultar(Guid? id);
    }
}
