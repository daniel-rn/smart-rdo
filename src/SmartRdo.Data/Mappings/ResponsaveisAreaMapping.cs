using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartRdo.Business.Models;

namespace SmartRdo.Data.Mappings
{
    public class ResponsaveisAreaMapping : IEntityTypeConfiguration<ResponsaveisArea>
    {
        public void Configure(EntityTypeBuilder<ResponsaveisArea> builder)
        {
            builder.ToTable("ResponsaveisArea");

            builder.HasOne(responsaveisArea => responsaveisArea.Responsavel)
                .WithMany(responsavel => responsavel.Areas)
                .HasForeignKey(responsaveisArea => responsaveisArea.ResponsavelAreaId);

            builder.HasOne(responsaveisArea => responsaveisArea.Area)
                .WithMany(area => area.ResponsaveisDaArea)
                .HasForeignKey(responsaveisArea => responsaveisArea.ResponsavelAreaId);
        }
    }
}
