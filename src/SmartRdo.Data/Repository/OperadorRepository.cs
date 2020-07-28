using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;

namespace SmartRdo.Data.Repository
{
    public class OperadorRepository : Repository<Operador>, IOperadorRepository
    {
        public OperadorRepository(SmartRdoDbContext db) : base(db)
        {
        }
    }
}
