using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;
using System.Collections.Generic;

namespace SmartRdo.Data.Mappings
{
    public class ItemChecklistEquipamentoMapping : IEntityTypeConfiguration<ItemChecklistEquipamento>
    {
        public void Configure(EntityTypeBuilder<ItemChecklistEquipamento> builder)
        {
            builder.ToTable("ItensChecklistsEquipamento");

            builder.HasKey(i => i.Id);

            //builder.Property(i => i.IdEquipamento)
            //    .D

            builder.Property(i => i.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");
        }
    }
}
