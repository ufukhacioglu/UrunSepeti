using AdaYazilim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdaYazilim.EntityConfiguration
{
    public class SepetConfiguration : IEntityTypeConfiguration<Sepet>
    {
        public void Configure(EntityTypeBuilder<Sepet> builder)
        {
            builder.ToTable("Sepet");
            builder.HasKey(x => x.SepetId);

        }
    }
}
