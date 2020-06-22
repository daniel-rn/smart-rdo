using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Context
{
    public class MyAplicationDbContext : DbContext
    {
        protected MyAplicationDbContext(DbContextOptions<MyAplicationDbContext> options) 
            : base(options)
        {
        }

        DbSet<Atividade> Atividades { get; set; }
    }
}
