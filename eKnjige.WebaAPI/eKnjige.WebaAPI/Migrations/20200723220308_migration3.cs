using Microsoft.EntityFrameworkCore.Migrations;

namespace eKnjige.WebaAPI.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Klijenti_Uloga_UlogaID",
                table: "Klijenti");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.AddForeignKey(
                name: "FK_Klijenti_Uloge_UlogaID",
                table: "Klijenti",
                column: "UlogaID",
                principalTable: "Uloge",
                principalColumn: "UlogaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Klijenti_Uloge_UlogaID",
                table: "Klijenti");

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Klijenti_Uloga_UlogaID",
                table: "Klijenti",
                column: "UlogaID",
                principalTable: "Uloga",
                principalColumn: "UlogaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
