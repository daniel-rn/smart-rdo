using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;

namespace SmartRdo.Data.Repository
{
    public class AreaRepository : Repository<Area>, IAreasRepository
    {
        public AreaRepository(SmartRdoDbContext db) : base(db)
        {
        }
    }
}
