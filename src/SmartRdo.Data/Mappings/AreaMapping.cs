using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Mappings
{
    public class AreaMapping : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable("Areas");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(a => a.CodigoArea)
                .IsRequired()
                .HasColumnType("varchar(13)");

            builder.HasMany(c => c.Atividades)
                .WithOne(a => a.Area)
                .HasForeignKey(a => a.AreaId);
        }
    }
}
