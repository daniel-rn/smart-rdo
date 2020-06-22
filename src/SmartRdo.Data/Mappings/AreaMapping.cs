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
        }
    }
}
