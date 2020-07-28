using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartRdo.Business.Models;

namespace SmartRdo.Business.Interfaces.services
{
    public interface IAtividadeService : IService<Atividade>
    {
    }

    public interface IService<T>
    {
        Task Adicione(T atividade);
        Task Atualize(T atividade);
        Task Remove(Guid id);
        Task<List<T>> ObterTodos();
        Task<T> Consultar(Guid? id);
    }
}
