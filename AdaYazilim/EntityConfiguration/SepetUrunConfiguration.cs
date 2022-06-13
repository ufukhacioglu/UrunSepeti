using AdaYazilim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdaYazilim.EntityConfiguration
{
    public class SepetUrunConfiguration : IEntityTypeConfiguration<SepetUrun>
    {
        public void Configure(EntityTypeBuilder<SepetUrun> builder)
        {
            builder.ToTable("SepetUrun");
            builder.HasKey(x => x.SepetUrunId);
            builder.Property(x => x.Tutar).IsRequired().HasColumnType("numeric");
        }
    }

}
