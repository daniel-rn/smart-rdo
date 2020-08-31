using SmartRdo.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRdo.Business.Interfaces.services
{
    public interface IService<T> where T : Entity
    {
        Task Adicione(T entidade);
        Task Atualize(T entidade);
        Task Remove(Guid id);
        Task<List<T>> ObterTodos();
        Task<T> Consultar(Guid? id);
    }
}
