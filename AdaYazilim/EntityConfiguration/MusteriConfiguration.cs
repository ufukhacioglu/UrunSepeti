using AdaYazilim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdaYazilim.EntityConfiguration
{
    public class MusteriConfiguration : IEntityTypeConfiguration<Musteri>
    {
        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.HasKey(x => x.MusteriId);
            builder.ToTable("Musteri");
            builder.Property(x => x.Ad).IsRequired();
            builder.Property(x => x.Soyad).IsRequired();
            builder.Property(x => x.Sehir).IsRequired();
        }
    }
}
