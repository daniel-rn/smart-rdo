using System;
using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Seeder.Seeds
{
    public class Seed001Clientes : ISeed
    {
        public void Executar(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = Guid.Parse("320923ee-b72b-46bb-b2d8-4ae4146ca2c3"), Nome = "Cliente A" },
                new Cliente { Id = Guid.Parse("b15227ac-d07f-4ccb-a346-e8638a50ddc5"), Nome = "Cliente B" }
            );
        }
    }
}