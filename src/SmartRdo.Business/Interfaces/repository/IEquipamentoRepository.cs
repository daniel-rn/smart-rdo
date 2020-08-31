using SmartRdo.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartRdo.Business.Interfaces.repository
{
    public interface IEquipamentoRepository : IRepository<Equipamento>
    {
        Task<IEnumerable<Equipamento>> ObterTodosComItensChecklist();
        Task<Equipamento> ObterPorIdComItensChecklist(Guid id);
    }
}
