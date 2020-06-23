using SmartRdo.Business.Models;
using SmartRdo.Data.Context;

namespace SmartRdo.Data.Repository
{
    public class AtividadeRepository : Repository<Atividade>
    {
        public AtividadeRepository(MyAplicationDbContext db) : base(db)
        {
        }
    }
}
