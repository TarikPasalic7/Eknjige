using eKnjige.Model;
using eKnjige.WebaAPI.Database;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace eKnjige.WebaAPI.Data
{
    public partial class AppContext :DbContext
    {

        public AppContext(DbContextOptions<AppContext> options) : base(options)
        { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PrijedlogKnjiga>()

                   .HasOne(pt => pt.Klijent)

                  .WithMany()

                 .HasForeignKey(pt => pt.KlijentID)

                  .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<KlijentKnjigaOcjena>()
                .HasOne(p => p.Klijent).WithMany().HasForeignKey(p => p.KlijentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<KupovinaKnjige>()
                .HasOne(p => p.Klijent).WithMany().HasForeignKey(p => p.KlijentID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Drzava>().HasData(new Drzava()
            {
                DrzavaID = 1,
                Naziv = "BiH"

            });
            modelBuilder.Entity<Drzava>().HasData(new Drzava()
            {
                DrzavaID = 2,
                Naziv = "Engleska"

            });
            modelBuilder.Entity<Spol>().HasData(new Spol()
            {
                SpolID=1,
                Tip="M"


            });
            modelBuilder.Entity<Spol>().HasData(new Spol()
            {
                SpolID = 2,
                Tip = "Z"


            });
            modelBuilder.Entity<Grad>().HasData(new Grad()
            {
               Id=1,
               DrzavaId=1,
               Naziv="Sarajevo"


            });
            modelBuilder.Entity<Grad>().HasData(new Grad()
            {
                Id = 2,
                DrzavaId = 1,
                Naziv = "Bosanska Krupa"


            });
            modelBuilder.Entity<Grad>().HasData(new Grad()
            {
                Id = 3,
                DrzavaId = 1,
                Naziv = "Mostar"


            });
            modelBuilder.Entity<Autor>().HasData(new Autor()
            {
                AutorID = 1,
                Godiste = DateTime.Now,
                Ime="Ivo",
                Prezime="Andric"

            });
            modelBuilder.Entity<Autor>().HasData(new Autor()
            {
                AutorID = 2,
                Godiste = DateTime.Now,
                Ime = "George",
                Prezime = "Martin"

            });
            modelBuilder.Entity<Autor>().HasData(new Autor()
            {
                AutorID = 3,
                Godiste = DateTime.Now,
                Ime = "Albert",
                Prezime = "Camus"

            });
            modelBuilder.Entity<Database.Uloga>().HasData(new Database.Uloga()
            {
                UlogaId=1,
                Naziv="Administrator",
                Opis="Administrator"

            });

            modelBuilder.Entity<Database.Uloga>().HasData(new Database.Uloga()
            {
                UlogaId = 2,
                Naziv = "Korisnik",
                Opis = "Korisnik"

            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID=1,
                Naziv="Roman"

            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 2,
                Naziv = "Novela"

            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija()
            {
                KategorijaID = 3,
                Naziv = "Naucna fantastika"

            });
            modelBuilder.Entity<Klijent>().HasData(new Klijent()
            {
               KlijentID=1,
               SpolID=1,
               DatumRodenja=DateTime.Now,
               Email="adminemail@gmail.com",
               Ime="AdminIme",
               Prezime="AdminPrezime",
               UlogaID=1,
               KorisnickoIme="admin",
               GradID=1,
               LozinkaHash= "FhbHHN34a5Ds1esUOVrfxM/3n8+X+1b5e5CaTnmPliUnx2i+dVsTEF2lX+GqfKaDTwfI7xnU8Vl27WuUC2c98w==",
               LozinkaSalt= "9ObBmhIwc8VyvImh4iDHLw=="

            });
            modelBuilder.Entity<Klijent>().HasData(new Klijent()
            {
                KlijentID =3,
                SpolID = 1,
                DatumRodenja = DateTime.Now,
                Email = "tarikpasalic@gmail.com",
                Ime = "Tarik",
                Prezime = "Pasalic",
                UlogaID = 2,
                KorisnickoIme = "tarikpasalic",
                GradID = 2,
                LozinkaHash = "RmrxC+TxcmGNxzNj/wVlHUzuqTO58XZ4iCikUBHXNq5ra5Or2L1VWCHkoB0Lp7VJxw8N+Fo/Ss5JXJceNNqPKA==",
                LozinkaSalt = "83VqAXdFhiIljRayFSH9aA=="

            });

         

            modelBuilder.Entity<EKnjiga>().HasData(new EKnjiga()
            {
               EKnjigaID=1,
               MP3Dodan=false,
               PDFDodan=true,
               AdministratorID=1,
               Cijena=34,
               OcjenaKnjige=5,
               Naziv="Sraz kraljeva",
               Mp3file=null,
               Pdffile= "George R. R. Martin 2 - Sraz kraljeva(1999.).pdf",
               Opis= "Opis	Nakon neočekivanog smaknuća Eddarda Starka, vazali i sljedbenici proglašavaju njegova sina Robba Kraljem na Sjeveru. Okrutni dječak Joffrey sjedi na Željeznom prijestolju i onemogućuje Stannisa i Renlyja Baratheona u pokušajima da zauzmu tron. Četiri pretendenta i samo jedna kruna! Sedam je Kraljevina na rubu razornoga " +
               "građanskog rata. Krvavocrveni komet na nebu samo potvrđuje nadolazeću katastrofu.",
               Slika=null
              
            });
            modelBuilder.Entity<EKnjiga>().HasData(new EKnjiga()
            {
                EKnjigaID = 2,
                MP3Dodan = false,
                PDFDodan = true,
                AdministratorID = 1,
                Cijena = 30,
                OcjenaKnjige = 4,
                Naziv = "Na Drini ćuprija",
                Mp3file = null,
                Pdffile = "Ivo-Andric-Na-Drini-cuprija.pdf",
                Opis = "Godine 1516. Mehmed paša je, prema vladajućem običaju devširme (tur. prikupljanje), kao dječak pravoslavnih roditelja odveden u osmansku vojsku (tadašnje janjičare), prilikom čega je prešao na islam, da bi se kasnije uzdigao ljestvicama vlasti i postao prvi do sultana. Kao moćnik, odlučio je da u rodnom kraju podigne zadužbinu, veliki kameni most na jedanaest lukova. Roman počinje dugim geografskim opisom višegradskog kraja i navođenjem više legendi o nastanku mosta. Jedna od najpoznatijih legendi svakako je priča o blizancima Stoji i Ostoji. Porijeklo legende je u nacionalnom mitu i epskoj viziji svijeta koja je književni ekvivalent toga mita. Legende su po pravilu paralelne, imaju krišćansku i muslimansku verziju. Kraj romana pada u 1914. godinu kada su trupe austrougarske monarhije, u povlačenju, ozbiljno oštetile most. Sa rušenjem mosta izdiše i Alihodža, jedan od najčešće pominjanih likova, koji simbolizuje kraj starih vremena..",
                Slika = null

            });
            modelBuilder.Entity<EKnjiga>().HasData(new EKnjiga()
            {
                EKnjigaID = 3,
                MP3Dodan = true,
                PDFDodan = true,
                AdministratorID = 1,
                Cijena = 25,
                OcjenaKnjige = 5,
                Naziv = "Stranac",
                Mp3file = "STRANAC Alber Kami I deo I,II i III glava.mp3",
                Pdffile = "alber_kami_stranac.pdf",
                Opis = "Psihološki roman Stranac Albert Camus objavio je 1942. godine. Ovaj je pisac unutar teorije egzistencijalizma vrhunski razvio filozofiju apsurda koju dijelimo na fazu apsurda i fazu pobune. Likovi poput Mersaulta i Sizifa ne opiru se apsurdu i ne bježe od besmislenosti života, već ga prihvaćaju i žive život po načelima teorije apsurda.",
                Slika = null

            });
            modelBuilder.Entity<EKnjigaKategorija>().HasData(new EKnjigaKategorija()
            {

                EKnjigaID = 1,
                EKnjigaKategorijaID = 1,
                KategorijaID = 1


            });
            modelBuilder.Entity<EKnjigaKategorija>().HasData(new EKnjigaKategorija()
            {

                EKnjigaID = 2,
                EKnjigaKategorijaID = 2,
                KategorijaID = 1


            });
            modelBuilder.Entity<EKnjigaKategorija>().HasData(new EKnjigaKategorija()
            {

                EKnjigaID = 3,
                EKnjigaKategorijaID = 3,
                KategorijaID = 2


            });
            modelBuilder.Entity<EKnjigaKategorija>().HasData(new EKnjigaKategorija()
            {

                EKnjigaID = 2,
                EKnjigaKategorijaID = 4,
                KategorijaID = 3


            });
            modelBuilder.Entity<EKnjigeAutor>().HasData(new EKnjigeAutor()
            {

                AutorID = 1,
                EKnjigeAutorID = 1,
                EKnjigaID = 2



            });
            modelBuilder.Entity<EKnjigeAutor>().HasData(new EKnjigeAutor()
            {

                AutorID = 2,
                EKnjigeAutorID = 2,
                EKnjigaID = 1



            });
            modelBuilder.Entity<EKnjigeAutor>().HasData(new EKnjigeAutor()
            {

                AutorID = 3,
                EKnjigeAutorID = 3,
                EKnjigaID = 3



            });
            modelBuilder.Entity<PrijedlogKnjiga>().HasData(new WebaAPI.PrijedlogKnjiga()
            {
                PrijedlogKnjigeID = 1,
                KlijentID = 3,
                Datum = DateTime.Now,
                Naziv = " Mesa Selimovic: Dervis i Smrt",
                Odgovoren = false,
                PogledaoKorisnik = false,
                Opis = ""


            });
            modelBuilder.Entity<PrijedlogKnjiga>().HasData(new WebaAPI.PrijedlogKnjiga()
            {
                PrijedlogKnjigeID = 2,
                KlijentID = 3,
                Datum = DateTime.Now,
                Naziv = " Lav Tolstoj : Rat i Mir",
                Odgovoren = true,
                PogledaoKorisnik = false,
                Opis = "Vaš zahtjev je odobren"


            });
            modelBuilder.Entity<Komentar>().HasData(new Komentar()
            {
                DatumKomentara = DateTime.Now,
                EKnjigaID = 3,
                KlijentID = 3,
                KomentarId = 1,
                komentar="Komentar 1"


            });
            modelBuilder.Entity<Komentar>().HasData(new Komentar()
            {
                DatumKomentara = DateTime.Now,
                EKnjigaID = 3,
                KlijentID = 3,
                KomentarId = 2,
                komentar="Komentar 2"


            });
            modelBuilder.Entity<Komentar>().HasData(new Komentar()
            {
                DatumKomentara = DateTime.Now,
                EKnjigaID = 1,
                KlijentID = 3,
                KomentarId = 3,
                komentar="Komentar"


            });
            modelBuilder.Entity<KupovinaKnjige>().HasData(new KupovinaKnjige()
            {

                KupovinaKnjigeID = 1,
                DatumKupovine = DateTime.Now,
                EKnjigaID = 3,
                KlijentID = 3


            });

        }


       
        public DbSet<Autor> Autori { get; set; }

        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<EKnjiga> EKnjige { get; set; }
        public DbSet<EKnjigaKategorija> EKnjigaKategorije { get; set; }

        public DbSet<EKnjigeAutor> EKnjigaAutori { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Kategorija> Kategorije { get; set; }
        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<KlijentKnjigaOcjena> KlijentKnjigaOcjene { get; set; }

        public DbSet<KupovinaKnjige> KupovinaKnjiga { get; set; }
        public DbSet<PrijedlogKnjiga> PrijedlogKnjiga { get; set; }
        public DbSet<Spol> Spol { get; set; }
        public DbSet<RSII25092020> RSII25092020 { get; set; }


        public DbSet<Komentar> Komentari { get; set; }

        public DbSet<Database.Uloga> Uloge { get; set; }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
