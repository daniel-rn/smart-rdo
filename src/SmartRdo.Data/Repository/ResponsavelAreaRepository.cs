using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;

namespace SmartRdo.Data.Repository
{
    public class ResponsavelAreaRepository : Repository<ResponsavelArea>, IResponsavelAreaRepository
    {
        public ResponsavelAreaRepository(SmartRdoDbContext db) : base(db)
        {
        }
    }
}
