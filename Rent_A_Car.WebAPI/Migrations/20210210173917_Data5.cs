using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent_A_Car.WebAPI.Migrations
{
    public partial class Data5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Klijent",
                keyColumn: "KlijentID",
                keyValue: 100,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "nUe9eZFIPVwrLzqNA4HRUBiZTuM=", "Tiyvv84iZyM0kfH/yTz9nw==" });

            migrationBuilder.UpdateData(
                table: "Klijent",
                keyColumn: "KlijentID",
                keyValue: 101,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "/y/IhSOwuDcYVsngxAuawdfffio=", "CgpOzs9xS0g5vX1N6CiQlg==" });

            migrationBuilder.UpdateData(
                table: "Popust",
                keyColumn: "PopustID",
                keyValue: 100,
                column: "DatumIsteka",
                value: new DateTime(2021, 2, 10, 18, 39, 15, 456, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Popust",
                keyColumn: "PopustID",
                keyValue: 101,
                column: "DatumIsteka",
                value: new DateTime(2021, 2, 10, 18, 39, 15, 459, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Popust",
                keyColumn: "PopustID",
                keyValue: 102,
                column: "DatumIsteka",
                value: new DateTime(2021, 2, 10, 18, 39, 15, 459, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.InsertData(
                table: "Rezervacija",
                columns: new[] { "RezervacijaID", "KlijentID", "KrajRezervacije", "LokacijaID", "Naziv", "OsiguranjeID", "PocetakRezervacije", "PopustID", "Status", "UkupnaCijena", "VoziloID" },
                values: new object[] { 100, 100, new DateTime(2021, 2, 10, 18, 39, 15, 472, DateTimeKind.Local).AddTicks(8540), 100, "Rezervacija test", 100, new DateTime(2021, 2, 10, 18, 39, 15, 472, DateTimeKind.Local).AddTicks(7878), 100, "Zavrseno", 15.0, 100 });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 100,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "eYLlnZMpCFh1PlesbFB/NEzLWsc=", "1RxIXIvwgxKmj12Hwm6PLw==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 101,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "Ieol5VE+PxsIKyIqd5picIsf51w=", "KByWvqoEj+UmOtW7uhxyaA==" });

            migrationBuilder.UpdateData(
                table: "DojmoviZahtjevi",
                keyColumn: "DojmoviZahtjeviID",
                keyValue: 100,
                column: "RezervacijaID",
                value: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaID",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "DojmoviZahtjevi",
                keyColumn: "DojmoviZahtjeviID",
                keyValue: 100,
                column: "RezervacijaID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Klijent",
                keyColumn: "KlijentID",
                keyValue: 100,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "Ig0fVSGnvfqvETe81Use+pPXXws=", "VEDOeXtdny/RUdwzP10hSw==" });

            migrationBuilder.UpdateData(
                table: "Klijent",
                keyColumn: "KlijentID",
                keyValue: 101,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "YxBRspkZ5tEjHW6SqTY4ggC1ykY=", "ktF2GxHLlcts33YCQVElQg==" });

            migrationBuilder.UpdateData(
                table: "Popust",
                keyColumn: "PopustID",
                keyValue: 100,
                column: "DatumIsteka",
                value: new DateTime(2021, 2, 10, 18, 28, 30, 883, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Popust",
                keyColumn: "PopustID",
                keyValue: 101,
                column: "DatumIsteka",
                value: new DateTime(2021, 2, 10, 18, 28, 30, 888, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Popust",
                keyColumn: "PopustID",
                keyValue: 102,
                column: "DatumIsteka",
                value: new DateTime(2021, 2, 10, 18, 28, 30, 888, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 100,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "aKBtq7zi2aCKThzt8RwIzyS+m/k=", "VJcsyPAmGp7w/OItMn5oQQ==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 101,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "NK0xpV59DSaxVa1EQqw4DTzwllg=", "tNfasb6B+17gvoeWgczCmw==" });
        }
    }
}
