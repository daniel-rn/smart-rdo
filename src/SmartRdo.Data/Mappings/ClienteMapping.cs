using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasMany(c => c.Atividades)
                .WithOne(a => a.Cliente)
                .HasForeignKey(a => a.ClienteId);
        }
    }
}
