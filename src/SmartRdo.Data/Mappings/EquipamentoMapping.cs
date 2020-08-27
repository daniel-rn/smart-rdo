using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Mappings
{
    public class EquipamentoMapping : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.ToTable("Equipamentos");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasMany(e => e.ItensChecklist)
                .WithOne(i => i.Equipamento)
                .HasForeignKey(i => i.IdEquipamento)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
