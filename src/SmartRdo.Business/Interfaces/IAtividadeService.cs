using SmartRdo.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRdo.Business.Interfaces
{
    public interface IAtividadeService
    {
        Task Adicione(Atividade atividade);
        Task Atualize(Atividade atividade);
        Task Remove(Guid id);
        Task<List<Atividade>> ObterTodos();
        Task<Atividade> Consultar(Guid? id);
    }
}
