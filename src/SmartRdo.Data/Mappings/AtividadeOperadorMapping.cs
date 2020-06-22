using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Mappings
{
    public class AtividadeOperadorMapping : IEntityTypeConfiguration<AtividadeOperador>
    {
        public void Configure(EntityTypeBuilder<AtividadeOperador> builder)
        {
            builder.ToTable("AtividadesOperadores");

            builder.HasOne(atividadeOperador => atividadeOperador.Operador)
                .WithMany(operador => operador.AtividadeOperador)
                .HasForeignKey(atividadeOperador => atividadeOperador.OperadorId);

            builder.HasOne(atividadeOperador => atividadeOperador.Ativividade)
                .WithMany(atividade => atividade.AtividadeOperador)
                .HasForeignKey(atividadeOperador => atividadeOperador.AtividadeId);
        }
    }
}
