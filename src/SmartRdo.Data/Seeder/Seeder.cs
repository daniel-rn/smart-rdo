using Microsoft.EntityFrameworkCore;
using SmartRdo.Data.Seeder.Seeds;
using System;
using System.Linq;
using System.Reflection;

public static class Seeder
{
    public static void ExecutarSeeds(this ModelBuilder modelBuilder)
    {
        var types = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.GetInterfaces().Contains(typeof(ISeed)));

        foreach (var type in types)
        {
            var instance = (ISeed)Activator.CreateInstance(type);
            instance.Executar(modelBuilder);
        }
    }
}