using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;
using SmartRdo.Data.Seeder.Seeds;
using System;

public class OperadoresSeed : ISeed
{
    public void Executar(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Operador>().HasData(
            new Operador { Id = Guid.Parse("c59c8d12-7ef0-47f7-9486-9c98b0589852"), Nome = "Daniel Nascimento" },
            new Operador { Id = Guid.Parse("a92df7e5-8692-4859-80ec-9662e5524989"), Nome = "Murilo Seno" },
            new Operador { Id = Guid.Parse("880c6a2a-a4d9-41d4-b886-84b48c16d6fe"), Nome = "Gabriel Cotrim" },
            new Operador { Id = Guid.Parse("362682de-e0a4-42e8-8e67-0ae9f720e724"), Nome = "Gustavo Souza" },
            new Operador { Id = Guid.Parse("3b87e8f9-aad1-4864-b8fc-e9d545c044f2"), Nome = "Ronaldo Ghesti" }
        );
    }
}