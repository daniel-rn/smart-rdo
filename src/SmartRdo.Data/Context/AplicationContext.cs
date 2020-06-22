using Microsoft.EntityFrameworkCore;

namespace SmartRdo.Data.Context
{
    public class AplicationContext : DbContext
    {
        protected AplicationContext(DbContextOptions<AplicationContext> options) 
            : base(options)
        {
        }
    }
}
