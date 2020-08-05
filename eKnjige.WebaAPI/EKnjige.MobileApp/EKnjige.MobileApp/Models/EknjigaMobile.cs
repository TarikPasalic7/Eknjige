using eKnjige.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EKnjige.MobileApp.Models
{
   public  class EknjigaMobile
    {
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

        public string Autori { get; set; }

        public string Kategorije { get; set; }

    }
}
