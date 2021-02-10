using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent_A_Car.WebAPI.Migrations
{
    public partial class Data2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lociranje",
                columns: table => new
                {
                    LociranjeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Lng = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Prihvaceno = table.Column<bool>(type: "bit", nullable: true),
                    Odogovoreno = table.Column<bool>(type: "bit", nullable: true),
                    VoziloId = table.Column<int>(type: "int", nullable: true),
                    KlijentId = table.Column<int>(type: "int", nullable: true),
                    ZaposlenikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lociranje", x => x.LociranjeId);
                    table.ForeignKey(
                        name: "FK__Lociranje__Klije__09746778",
                        column: x => x.KlijentId,
                        principalTable: "Klijent",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Lociranje__Vozil__0880433F",
                        column: x => x.VoziloId,
                        principalTable: "Vozilo",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Lociranje__Zapos__0A688BB1",
                        column: x => x.ZaposlenikId,
                        principalTable: "Zaposlenik",
                        principalColumn: "ZaposlenikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Drzava",
                columns: new[] { "DrzavaID", "Naziv", "Oznaka" },
                values: new object[] { 100, "Bosna i Hercegovina", "BiH" });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 100,
                columns: new[] { "DrzavaID", "Naziv", "PostanskiBr" },
                values: new object[] { 100, "Mostar", "88000" });

            migrationBuilder.InsertData(
                table: "Grad",
                columns: new[] { "GradID", "DrzavaID", "Naziv", "PostanskiBr" },
                values: new object[] { 101, 100, "Sarajevo", "72000" });

            migrationBuilder.CreateIndex(
                name: "IX_Lociranje_KlijentId",
                table: "Lociranje",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lociranje_VoziloId",
                table: "Lociranje",
                column: "VoziloId");

            migrationBuilder.CreateIndex(
                name: "IX_Lociranje_ZaposlenikId",
                table: "Lociranje",
                column: "ZaposlenikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lociranje");

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "DrzavaID",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 100,
                columns: new[] { "DrzavaID", "Naziv", "PostanskiBr" },
                values: new object[] { 1, "Banja Luka", "82000" });
        }
    }
}
