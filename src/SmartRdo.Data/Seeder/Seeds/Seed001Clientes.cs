using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;
using SmartRdo.Data.Seeder.Seeds;

public class Seed001Clientes : ISeed
{
    public void Executar(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>().HasData(
            new Cliente { Nome = "Cliente A" },
            new Cliente { Nome = "Cliente B" }
        );
    }
}