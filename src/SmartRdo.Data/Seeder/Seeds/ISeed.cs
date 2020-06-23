using Microsoft.EntityFrameworkCore;

namespace SmartRdo.Data.Seeder.Seeds
{
    interface ISeed
    {
        public void Executar(ModelBuilder modelBuilder);
    }
}
