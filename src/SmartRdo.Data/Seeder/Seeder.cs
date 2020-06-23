using Microsoft.EntityFrameworkCore;

public static class Seeder
{
    public static void ExecutarSeeds(this ModelBuilder modelBuilder)
    {
        new OperadoresSeed().Executar(modelBuilder);
    }
}