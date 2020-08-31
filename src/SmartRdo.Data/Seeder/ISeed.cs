using Microsoft.EntityFrameworkCore;

namespace SmartRdo.Data.Seeder
{
    internal interface ISeed
    {
        public void Executar(ModelBuilder modelBuilder);
    }
}
