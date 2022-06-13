using Microsoft.EntityFrameworkCore.Migrations;

namespace AdaYazilim.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    MusteriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.MusteriId);
                });

            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    SepetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.SepetId);
                    table.ForeignKey(
                        name: "FK_Sepet_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "MusteriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SepetUrun",
                columns: table => new
                {
                    SepetUrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tutar = table.Column<decimal>(type: "numeric", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SepetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SepetUrun", x => x.SepetUrunId);
                    table.ForeignKey(
                        name: "FK_SepetUrun_Sepet_SepetId",
                        column: x => x.SepetId,
                        principalTable: "Sepet",
                        principalColumn: "SepetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sepet_MusteriId",
                table: "Sepet",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_SepetUrun_SepetId",
                table: "SepetUrun",
                column: "SepetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SepetUrun");

            migrationBuilder.DropTable(
                name: "Sepet");

            migrationBuilder.DropTable(
                name: "Musteri");
        }
    }
}
