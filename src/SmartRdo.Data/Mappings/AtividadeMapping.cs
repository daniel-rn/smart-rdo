using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Mappings
{
    public class AtividadeMapping : IEntityTypeConfiguration<Atividade>
    {
        public void Configure(EntityTypeBuilder<Atividade> builder)
        {
            builder.ToTable("Atividades");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Codigo)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(a => a.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(a => a.LocalDescarte)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.HasMany(a => a.AtividadeFotos)
                .WithOne(f => f.Atividade)
                .HasForeignKey(f => f.AtividadeId);

            builder.HasMany(a => a.AtividadeOperador)
                .WithOne(o => o.Ativividade)
                .HasForeignKey(o => o.AtividadeId);
        }
    }
}
