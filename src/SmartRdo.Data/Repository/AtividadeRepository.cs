using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces.repository;

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

        public override async Task<List<Atividade>> ObterTodos()
        {
            return await Db.Atividades
                .Include(a => a.Area)
                .Include(a => a.Cliente)
                .Include(a => a.Operador)
                .Include(a => a.ResponsavelArea)
                .ToListAsync();
        }

        public async Task<Atividade> Consultar(Guid? id)
        {
            return await Db.Atividades
                .Include(a => a.Area)
                .Include(a => a.Cliente)
                .Include(a => a.Operador)
                .Include(a => a.ResponsavelArea)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
