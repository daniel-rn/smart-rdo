using System;
using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Seeder.Seeds
{
    public class Seed002Equipamentos : ISeed
    {
        public void Executar(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipamento>().HasData(
                new Equipamento { Id = Guid.Parse("60f9b002-0f51-481c-a657-98a99e132242"), Nome = "Equipamento A" },
                new Equipamento { Id = Guid.Parse("1bd1c1ec-c7c4-4042-a321-8a5fe4647b43"), Nome = "Equipamento B" }
            );
        }
    }
}