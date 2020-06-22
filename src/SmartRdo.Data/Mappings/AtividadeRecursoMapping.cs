using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Mappings
{
    public class AtividadeRecursoMapping : IEntityTypeConfiguration<AtividadeRecurso>
    {
        public void Configure(EntityTypeBuilder<AtividadeRecurso> builder)
        {
            builder.ToTable("AtividadesRecursos");

            builder.HasOne(atividadeRecurso => atividadeRecurso.Recurso)
                .WithMany(recurso => recurso.AtividadeRecurso)
                .HasForeignKey(atividadeRecurso => atividadeRecurso.RecursoId);

            builder.HasOne(atividadeRecurso => atividadeRecurso.Atividade)
                .WithMany(atividade => atividade.AtividadeRecurso)
                .HasForeignKey(atividadeOperador => atividadeOperador.AtividadeId);
        }
    }
}
