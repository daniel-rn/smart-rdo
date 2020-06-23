using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;
using System.Linq;

namespace SmartRdo.Data.Context
{
    public class MyAplicationDbContext : DbContext
    {
        public MyAplicationDbContext(DbContextOptions<MyAplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Operador> Operadores { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<AtividadeFotos> AtividadesFotos {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyAplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
