


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKnjige.WebaAPI
{
    public class EKnjiga
    {
        [Key]
        public int EKnjigaID { get; set; }
        public string Naziv { get; set; }
        public float OcjenaKnjige { get; set; }
        public byte[] Slika { get; set; }
        public float Cijena { get; set; }
        public byte[] Mp3file { get; set; } 
        public byte[] Pdffile { get; set; }
        public string Opis { get; set; }

        public bool MP3Dodan { get; set; }

        public bool PDFDodan { get; set; }



        public Klijent  Administrator { get; set; }
        public int AdministratorID { get; set; }
    }
}
