// <auto-generated />
using AdaYazilim.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdaYazilim.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdaYazilim.Entities.Concrete.Musteri", b =>
                {
                    b.Property<int>("MusteriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusteriId");

                    b.ToTable("Musteri");
                });

            modelBuilder.Entity("AdaYazilim.Entities.Concrete.Sepet", b =>
                {
                    b.Property<int>("SepetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.HasKey("SepetId");

                    b.HasIndex("MusteriId");

                    b.ToTable("Sepet");
                });

            modelBuilder.Entity("AdaYazilim.Entities.Concrete.SepetUrun", b =>
                {
                    b.Property<int>("SepetUrunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SepetId")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("numeric");

                    b.HasKey("SepetUrunId");

                    b.HasIndex("SepetId");

                    b.ToTable("SepetUrun");
                });

            modelBuilder.Entity("AdaYazilim.Entities.Concrete.Sepet", b =>
                {
                    b.HasOne("AdaYazilim.Entities.Concrete.Musteri", "Musteri")
                        .WithMany("Sepetler")
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("AdaYazilim.Entities.Concrete.SepetUrun", b =>
                {
                    b.HasOne("AdaYazilim.Entities.Concrete.Sepet", "Sepet")
                        .WithMany("SepetUrunler")
                        .HasForeignKey("SepetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sepet");
                });

            modelBuilder.Entity("AdaYazilim.Entities.Concrete.Musteri", b =>
                {
                    b.Navigation("Sepetler");
                });

            modelBuilder.Entity("AdaYazilim.Entities.Concrete.Sepet", b =>
                {
                    b.Navigation("SepetUrunler");
                });
#pragma warning restore 612, 618
        }
    }
}
