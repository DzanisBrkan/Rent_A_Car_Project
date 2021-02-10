using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent_A_Car.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__DojmoviZa__Vozil__03BB8E22",
                table: "DojmoviZahtjevi");

            migrationBuilder.RenameColumn(
                name: "VoziloID",
                table: "DojmoviZahtjevi",
                newName: "RezervacijaID");

            migrationBuilder.RenameIndex(
                name: "IX_DojmoviZahtjevi_VoziloID",
                table: "DojmoviZahtjevi",
                newName: "IX_DojmoviZahtjevi_RezervacijaID");

            migrationBuilder.AddColumn<double>(
                name: "Langitude",
                table: "Vozilo",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Vozilo",
                type: "float",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK__DojmoviZa__Rezer__05A3D694",
                table: "DojmoviZahtjevi",
                column: "RezervacijaID",
                principalTable: "Rezervacija",
                principalColumn: "RezervacijaID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__DojmoviZa__Rezer__05A3D694",
                table: "DojmoviZahtjevi");

            migrationBuilder.DropColumn(
                name: "Langitude",
                table: "Vozilo");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Vozilo");

            migrationBuilder.RenameColumn(
                name: "RezervacijaID",
                table: "DojmoviZahtjevi",
                newName: "VoziloID");

            migrationBuilder.RenameIndex(
                name: "IX_DojmoviZahtjevi_RezervacijaID",
                table: "DojmoviZahtjevi",
                newName: "IX_DojmoviZahtjevi_VoziloID");

            migrationBuilder.AddForeignKey(
                name: "FK__DojmoviZa__Vozil__03BB8E22",
                table: "DojmoviZahtjevi",
                column: "VoziloID",
                principalTable: "Vozilo",
                principalColumn: "VoziloID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
