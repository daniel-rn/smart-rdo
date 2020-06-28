using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRdo.Data.Repository
{
    public class AtividadeRepository : Repository<Atividade>, IAtividadeRepository
    {
        public AtividadeRepository(SmartRdoDbContext db) : base(db){ }

        public async Task<Atividade> ObtenhaAtivdadeOperador(Guid id)
        {
            return await Db.Atividades.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Atividade>> ObtenhaAtividadesOperadores()
        {
            return await Db.Atividades.AsNoTracking().Include(a => a.AtividadeOperador)
                .OrderBy(a => a.Descricao).ToListAsync();
        }

        public async Task<IEnumerable<Atividade>> ObtenhaAtividadesPorOperador(Guid operadorId)
        {
            return await Buscar(a => a.AtividadeOperador.All(ao => ao.OperadorId == operadorId));
        }
    }
}
