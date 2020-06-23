using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Mappings
{
    public class AtividadeFotosMapping : IEntityTypeConfiguration<AtividadeFotos>
    {
        public void Configure(EntityTypeBuilder<AtividadeFotos> builder)
        {
            builder.ToTable("AtividadesFotos");

            builder.HasKey(f => f.Id);
            
            builder.Property(f => f.Foto)
                .IsRequired()
                .HasColumnType("varchar(200)");
        }
    }
}
