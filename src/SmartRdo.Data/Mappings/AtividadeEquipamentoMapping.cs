using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Mappings
{
    public class AtividadeEquipamentoMapping : IEntityTypeConfiguration<AtividadeEquipamento>
    {
        public void Configure(EntityTypeBuilder<AtividadeEquipamento> builder)
        {
            builder.ToTable("AtividadesEquipamento");

            builder.HasOne(atividadeRecurso => atividadeRecurso.Equipamento)
                .WithMany(recurso => recurso.AtividadeEquipamento)
                .HasForeignKey(atividadeRecurso => atividadeRecurso.EquipamentoId);

            builder.HasOne(atividadeRecurso => atividadeRecurso.Atividade)
                .WithMany(atividade => atividade.AtividadeEquipamento)
                .HasForeignKey(atividadeOperador => atividadeOperador.AtividadeId);
        }
    }
}
