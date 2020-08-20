using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKnjige.WebaAPI.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autori",
                columns: table => new
                {
                    AutorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Godiste = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autori", x => x.AutorID);
                });

            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Kategorije",
                columns: table => new
                {
                    KategorijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorije", x => x.KategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    SpolID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.SpolID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Klijenti",
                columns: table => new
                {
                    KlijentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DatumRodenja = table.Column<DateTime>(nullable: false),
                    SpolID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false),
                    UlogaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijenti", x => x.KlijentID);
                    table.ForeignKey(
                        name: "FK_Klijenti_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Klijenti_Spol_SpolID",
                        column: x => x.SpolID,
                        principalTable: "Spol",
                        principalColumn: "SpolID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Klijenti_Uloge_UlogaID",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EKnjige",
                columns: table => new
                {
                    EKnjigaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    OcjenaKnjige = table.Column<float>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    Cijena = table.Column<float>(nullable: false),
                    Mp3file = table.Column<string>(nullable: true),
                    Pdffile = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    MP3Dodan = table.Column<bool>(nullable: false),
                    PDFDodan = table.Column<bool>(nullable: false),
                    AdministratorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EKnjige", x => x.EKnjigaID);
                    table.ForeignKey(
                        name: "FK_EKnjige_Klijenti_AdministratorID",
                        column: x => x.AdministratorID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrijedlogKnjiga",
                columns: table => new
                {
                    PrijedlogKnjigeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    Odgovoren = table.Column<bool>(nullable: false),
                    PogledaoKorisnik = table.Column<bool>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    KlijentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrijedlogKnjiga", x => x.PrijedlogKnjigeID);
                    table.ForeignKey(
                        name: "FK_PrijedlogKnjiga_Klijenti_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EKnjigaAutori",
                columns: table => new
                {
                    EKnjigeAutorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorID = table.Column<int>(nullable: false),
                    EKnjigaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EKnjigaAutori", x => x.EKnjigeAutorID);
                    table.ForeignKey(
                        name: "FK_EKnjigaAutori_Autori_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Autori",
                        principalColumn: "AutorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EKnjigaAutori_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EKnjigaKategorije",
                columns: table => new
                {
                    EKnjigaKategorijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EKnjigaID = table.Column<int>(nullable: false),
                    KategorijaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EKnjigaKategorije", x => x.EKnjigaKategorijaID);
                    table.ForeignKey(
                        name: "FK_EKnjigaKategorije_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EKnjigaKategorije_Kategorije_KategorijaID",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KlijentKnjigaOcjene",
                columns: table => new
                {
                    KlijentKnjigaOcijenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOcijene = table.Column<DateTime>(nullable: false),
                    Ocjena = table.Column<float>(nullable: false),
                    KlijentID = table.Column<int>(nullable: false),
                    EKnjigaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KlijentKnjigaOcjene", x => x.KlijentKnjigaOcijenaID);
                    table.ForeignKey(
                        name: "FK_KlijentKnjigaOcjene_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KlijentKnjigaOcjene_Klijenti_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentari",
                columns: table => new
                {
                    KomentarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    komentar = table.Column<string>(nullable: true),
                    DatumKomentara = table.Column<DateTime>(nullable: false),
                    KlijentID = table.Column<int>(nullable: false),
                    EKnjigaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentari", x => x.KomentarId);
                    table.ForeignKey(
                        name: "FK_Komentari_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Komentari_Klijenti_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "KupovinaKnjiga",
                columns: table => new
                {
                    KupovinaKnjigeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumKupovine = table.Column<DateTime>(nullable: false),
                    KlijentID = table.Column<int>(nullable: false),
                    EKnjigaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupovinaKnjiga", x => x.KupovinaKnjigeID);
                    table.ForeignKey(
                        name: "FK_KupovinaKnjiga_EKnjige_EKnjigaID",
                        column: x => x.EKnjigaID,
                        principalTable: "EKnjige",
                        principalColumn: "EKnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupovinaKnjiga_Klijenti_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Autori",
                columns: new[] { "AutorID", "Godiste", "Ime", "Prezime" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 20, 20, 19, 0, 976, DateTimeKind.Local).AddTicks(3171), "Ivo", "Andric" },
                    { 2, new DateTime(2020, 8, 20, 20, 19, 0, 979, DateTimeKind.Local).AddTicks(4033), "George", "Martin" },
                    { 3, new DateTime(2020, 8, 20, 20, 19, 0, 979, DateTimeKind.Local).AddTicks(4142), "Albert", "Camus" }
                });

            migrationBuilder.InsertData(
                table: "Drzave",
                columns: new[] { "DrzavaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "BiH" },
                    { 2, "Engleska" }
                });

            migrationBuilder.InsertData(
                table: "Kategorije",
                columns: new[] { "KategorijaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Roman" },
                    { 2, "Novela" },
                    { 3, "Naucna fantastika" }
                });

            migrationBuilder.InsertData(
                table: "Spol",
                columns: new[] { "SpolID", "Tip" },
                values: new object[,]
                {
                    { 1, "M" },
                    { 2, "Z" }
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "UlogaId", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 1, "Administrator", "Administrator" },
                    { 2, "Korisnik", "Korisnik" }
                });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "Id", "DrzavaId", "Naziv" },
                values: new object[] { 1, 1, "Sarajevo" });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "Id", "DrzavaId", "Naziv" },
                values: new object[] { 2, 1, "Bosanska Krupa" });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "Id", "DrzavaId", "Naziv" },
                values: new object[] { 3, 1, "Mostar" });

            migrationBuilder.InsertData(
                table: "Klijenti",
                columns: new[] { "KlijentID", "DatumRodenja", "Email", "GradID", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "SpolID", "UlogaID" },
                values: new object[] { 1, new DateTime(2020, 8, 20, 20, 19, 0, 979, DateTimeKind.Local).AddTicks(9847), "adminemail@gmail.com", 1, "AdminIme", "admin", "FhbHHN34a5Ds1esUOVrfxM/3n8+X+1b5e5CaTnmPliUnx2i+dVsTEF2lX+GqfKaDTwfI7xnU8Vl27WuUC2c98w==", "9ObBmhIwc8VyvImh4iDHLw==", "AdminPrezime", 1, 1 });

            migrationBuilder.InsertData(
                table: "Klijenti",
                columns: new[] { "KlijentID", "DatumRodenja", "Email", "GradID", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "SpolID", "UlogaID" },
                values: new object[] { 3, new DateTime(2020, 8, 20, 20, 19, 0, 980, DateTimeKind.Local).AddTicks(4088), "tarikpasalic@gmail.com", 2, "Tarik", "tarikpasalic", "RmrxC+TxcmGNxzNj/wVlHUzuqTO58XZ4iCikUBHXNq5ra5Or2L1VWCHkoB0Lp7VJxw8N+Fo/Ss5JXJceNNqPKA==", "83VqAXdFhiIljRayFSH9aA==", "Pasalic", 1, 2 });

            migrationBuilder.InsertData(
                table: "EKnjige",
                columns: new[] { "EKnjigaID", "AdministratorID", "Cijena", "MP3Dodan", "Mp3file", "Naziv", "OcjenaKnjige", "Opis", "PDFDodan", "Pdffile", "Slika" },
                values: new object[] { 1, 1, 34f, false, null, "Sraz kraljeva", 5f, "Opis	Nakon neočekivanog smaknuća Eddarda Starka, vazali i sljedbenici proglašavaju njegova sina Robba Kraljem na Sjeveru. Okrutni dječak Joffrey sjedi na Željeznom prijestolju i onemogućuje Stannisa i Renlyja Baratheona u pokušajima da zauzmu tron. Četiri pretendenta i samo jedna kruna! Sedam je Kraljevina na rubu razornoga građanskog rata. Krvavocrveni komet na nebu samo potvrđuje nadolazeću katastrofu.", true, "George R. R. Martin 2 - Sraz kraljeva(1999.).pdf", null });

            migrationBuilder.InsertData(
                table: "EKnjige",
                columns: new[] { "EKnjigaID", "AdministratorID", "Cijena", "MP3Dodan", "Mp3file", "Naziv", "OcjenaKnjige", "Opis", "PDFDodan", "Pdffile", "Slika" },
                values: new object[] { 2, 1, 30f, false, null, "Na Drini ćuprija", 4f, "Godine 1516. Mehmed paša je, prema vladajućem običaju devširme (tur. prikupljanje), kao dječak pravoslavnih roditelja odveden u osmansku vojsku (tadašnje janjičare), prilikom čega je prešao na islam, da bi se kasnije uzdigao ljestvicama vlasti i postao prvi do sultana. Kao moćnik, odlučio je da u rodnom kraju podigne zadužbinu, veliki kameni most na jedanaest lukova. Roman počinje dugim geografskim opisom višegradskog kraja i navođenjem više legendi o nastanku mosta. Jedna od najpoznatijih legendi svakako je priča o blizancima Stoji i Ostoji. Porijeklo legende je u nacionalnom mitu i epskoj viziji svijeta koja je književni ekvivalent toga mita. Legende su po pravilu paralelne, imaju krišćansku i muslimansku verziju. Kraj romana pada u 1914. godinu kada su trupe austrougarske monarhije, u povlačenju, ozbiljno oštetile most. Sa rušenjem mosta izdiše i Alihodža, jedan od najčešće pominjanih likova, koji simbolizuje kraj starih vremena..", true, "Ivo-Andric-Na-Drini-cuprija.pdf", null });

            migrationBuilder.InsertData(
                table: "EKnjige",
                columns: new[] { "EKnjigaID", "AdministratorID", "Cijena", "MP3Dodan", "Mp3file", "Naziv", "OcjenaKnjige", "Opis", "PDFDodan", "Pdffile", "Slika" },
                values: new object[] { 3, 1, 25f, true, "STRANAC Alber Kami I deo I,II i III glava.mp3", "Stranac", 5f, "Psihološki roman Stranac Albert Camus objavio je 1942. godine. Ovaj je pisac unutar teorije egzistencijalizma vrhunski razvio filozofiju apsurda koju dijelimo na fazu apsurda i fazu pobune. Likovi poput Mersaulta i Sizifa ne opiru se apsurdu i ne bježe od besmislenosti života, već ga prihvaćaju i žive život po načelima teorije apsurda.", true, "alber_kami_stranac.pdf", null });

            migrationBuilder.InsertData(
                table: "EKnjigaAutori",
                columns: new[] { "EKnjigeAutorID", "AutorID", "EKnjigaID" },
                values: new object[,]
                {
                    { 2, 2, 1 },
                    { 1, 1, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "EKnjigaKategorije",
                columns: new[] { "EKnjigaKategorijaID", "EKnjigaID", "KategorijaID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 4, 2, 3 },
                    { 3, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Komentari",
                columns: new[] { "KomentarId", "DatumKomentara", "EKnjigaID", "KlijentID", "komentar" },
                values: new object[,]
                {
                    { 3, new DateTime(2020, 8, 20, 20, 19, 0, 981, DateTimeKind.Local).AddTicks(7486), 1, 3, "Komentar" },
                    { 1, new DateTime(2020, 8, 20, 20, 19, 0, 981, DateTimeKind.Local).AddTicks(4958), 3, 3, "Komentar 1" },
                    { 2, new DateTime(2020, 8, 20, 20, 19, 0, 981, DateTimeKind.Local).AddTicks(7403), 3, 3, "Komentar 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaAutori_AutorID",
                table: "EKnjigaAutori",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaAutori_EKnjigaID",
                table: "EKnjigaAutori",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaKategorije_EKnjigaID",
                table: "EKnjigaKategorije",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjigaKategorije_KategorijaID",
                table: "EKnjigaKategorije",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_EKnjige_AdministratorID",
                table: "EKnjige",
                column: "AdministratorID");

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaId",
                table: "Gradovi",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Klijenti_GradID",
                table: "Klijenti",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Klijenti_SpolID",
                table: "Klijenti",
                column: "SpolID");

            migrationBuilder.CreateIndex(
                name: "IX_Klijenti_UlogaID",
                table: "Klijenti",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_KlijentKnjigaOcjene_EKnjigaID",
                table: "KlijentKnjigaOcjene",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_KlijentKnjigaOcjene_KlijentID",
                table: "KlijentKnjigaOcjene",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_EKnjigaID",
                table: "Komentari",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_KlijentID",
                table: "Komentari",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaKnjiga_EKnjigaID",
                table: "KupovinaKnjiga",
                column: "EKnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaKnjiga_KlijentID",
                table: "KupovinaKnjiga",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_PrijedlogKnjiga_KlijentID",
                table: "PrijedlogKnjiga",
                column: "KlijentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EKnjigaAutori");

            migrationBuilder.DropTable(
                name: "EKnjigaKategorije");

            migrationBuilder.DropTable(
                name: "KlijentKnjigaOcjene");

            migrationBuilder.DropTable(
                name: "Komentari");

            migrationBuilder.DropTable(
                name: "KupovinaKnjiga");

            migrationBuilder.DropTable(
                name: "PrijedlogKnjiga");

            migrationBuilder.DropTable(
                name: "Autori");

            migrationBuilder.DropTable(
                name: "Kategorije");

            migrationBuilder.DropTable(
                name: "EKnjige");

            migrationBuilder.DropTable(
                name: "Klijenti");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Spol");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
