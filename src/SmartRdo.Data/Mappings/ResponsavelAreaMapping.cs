using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Mappings
{
    public class ResponsavelAreaMapping : IEntityTypeConfiguration<ResponsavelArea>
    {
        public void Configure(EntityTypeBuilder<ResponsavelArea> builder)
        {
            builder.ToTable("Responsaveis");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("varchar(20)");
        }
    }
}
