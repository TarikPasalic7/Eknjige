using Microsoft.EntityFrameworkCore.Migrations;

namespace eKnjige.WebaAPI.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lozinka",
                table: "Klijenti");

            migrationBuilder.AddColumn<string>(
                name: "LozinkaHash",
                table: "Klijenti",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaSalt",
                table: "Klijenti",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LozinkaHash",
                table: "Klijenti");

            migrationBuilder.DropColumn(
                name: "LozinkaSalt",
                table: "Klijenti");

            migrationBuilder.AddColumn<string>(
                name: "Lozinka",
                table: "Klijenti",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
