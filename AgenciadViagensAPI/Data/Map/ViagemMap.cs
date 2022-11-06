using AgenciadViagensAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenciadViagensAPI.Data.Map
{
    public class ViagemMap : IEntityTypeConfiguration<ViagemModel>
    {
        public void Configure(EntityTypeBuilder<ViagemModel> builder)
        {
           builder.HasKey(x => x.Id);
            builder.Property(x => x.origem).IsRequired().HasMaxLength(255);
            builder.Property(x => x.destino).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(150);
        }
    }
}
