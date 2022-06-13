using AdaYazilim.Entities.Concrete;
using AdaYazilim.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace AdaYazilim.Context
{
    public class DatabaseContext :DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Sepet> Sepetler { get; set; }
        public DbSet<SepetUrun> SepetUrunler { get; set; }


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MusteriConfiguration());
            modelBuilder.ApplyConfiguration(new SepetConfiguration());
            modelBuilder.ApplyConfiguration(new SepetUrunConfiguration());
        }
    }
}
