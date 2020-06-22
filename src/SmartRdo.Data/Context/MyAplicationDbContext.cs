using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Context
{
    public class MyAplicationDbContext : DbContext
    {
        public MyAplicationDbContext(DbContextOptions<MyAplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<Atividade> Atividades { get; set; }
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Operador> Operadores { get; set; }
        DbSet<Recurso> Recursos { get; set; }
        DbSet<Area> Areas { get; set; }
        DbSet<AtividadeFotos> AtividadesFotos {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyAplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
