using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Context
{
    public class AplicationContext : DbContext
    {
        protected AplicationContext(DbContextOptions<AplicationContext> options) 
            : base(options)
        {
        }

        DbSet<Atividade> Atividades { get; set; }
    }
}
