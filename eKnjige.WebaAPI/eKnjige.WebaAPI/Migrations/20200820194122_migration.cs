using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKnjige.WebaAPI.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Autori",
                keyColumn: "AutorID",
                keyValue: 1,
                column: "Godiste",
                value: new DateTime(2020, 8, 20, 21, 41, 21, 362, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Autori",
                keyColumn: "AutorID",
                keyValue: 2,
                column: "Godiste",
                value: new DateTime(2020, 8, 20, 21, 41, 21, 366, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Autori",
                keyColumn: "AutorID",
                keyValue: 3,
                column: "Godiste",
                value: new DateTime(2020, 8, 20, 21, 41, 21, 366, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentID",
                keyValue: 1,
                column: "DatumRodenja",
                value: new DateTime(2020, 8, 20, 21, 41, 21, 367, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentID",
                keyValue: 3,
                column: "DatumRodenja",
                value: new DateTime(2020, 8, 20, 21, 41, 21, 368, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "KomentarId",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2020, 8, 20, 21, 41, 21, 370, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "KomentarId",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2020, 8, 20, 21, 41, 21, 370, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "KomentarId",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2020, 8, 20, 21, 41, 21, 370, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.InsertData(
                table: "KupovinaKnjiga",
                columns: new[] { "KupovinaKnjigeID", "DatumKupovine", "EKnjigaID", "KlijentID" },
                values: new object[] { 1, new DateTime(2020, 8, 20, 21, 41, 21, 371, DateTimeKind.Local).AddTicks(1130), 3, 3 });

            migrationBuilder.InsertData(
                table: "PrijedlogKnjiga",
                columns: new[] { "PrijedlogKnjigeID", "Datum", "KlijentID", "Naziv", "Odgovoren", "Opis", "PogledaoKorisnik" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 20, 21, 41, 21, 370, DateTimeKind.Local).AddTicks(1552), 3, " Mesa Selimovic: Dervis i Smrt", false, "", false },
                    { 2, new DateTime(2020, 8, 20, 21, 41, 21, 370, DateTimeKind.Local).AddTicks(5072), 3, " Lav Tolstoj : Rat i Mir", true, "Vaš zahtjev je odobren", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KupovinaKnjiga",
                keyColumn: "KupovinaKnjigeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrijedlogKnjiga",
                keyColumn: "PrijedlogKnjigeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrijedlogKnjiga",
                keyColumn: "PrijedlogKnjigeID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Autori",
                keyColumn: "AutorID",
                keyValue: 1,
                column: "Godiste",
                value: new DateTime(2020, 8, 20, 20, 19, 0, 976, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Autori",
                keyColumn: "AutorID",
                keyValue: 2,
                column: "Godiste",
                value: new DateTime(2020, 8, 20, 20, 19, 0, 979, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Autori",
                keyColumn: "AutorID",
                keyValue: 3,
                column: "Godiste",
                value: new DateTime(2020, 8, 20, 20, 19, 0, 979, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentID",
                keyValue: 1,
                column: "DatumRodenja",
                value: new DateTime(2020, 8, 20, 20, 19, 0, 979, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentID",
                keyValue: 3,
                column: "DatumRodenja",
                value: new DateTime(2020, 8, 20, 20, 19, 0, 980, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "KomentarId",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2020, 8, 20, 20, 19, 0, 981, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "KomentarId",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2020, 8, 20, 20, 19, 0, 981, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "KomentarId",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2020, 8, 20, 20, 19, 0, 981, DateTimeKind.Local).AddTicks(7486));
        }
    }
}
