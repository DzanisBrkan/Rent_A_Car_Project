using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent_A_Car.WebAPI.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Grad",
                columns: new[] { "GradID", "DrzavaID", "Naziv", "PostanskiBr" },
                values: new object[] { 100, 1, "Banja Luka", "82000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 100);
        }
    }
}
