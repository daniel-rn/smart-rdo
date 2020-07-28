using SmartRdo.Business.Models;
using SmartRdo.Data.Context;
using SmartRdo.Business.Interfaces.repository;

namespace SmartRdo.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(SmartRdoDbContext db) : base(db)
        {
        }
    }
}
