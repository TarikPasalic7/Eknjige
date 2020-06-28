using System;
using System.Collections.Generic;
using System.Text;

namespace eKnjige.Model.Requests
{
   public class EKnjigaInsertRequest
    {
        
        public string Naziv { get; set; }
        public float OcjenaKnjige { get; set; }
        public string Slika { get; set; }
        public float Cijena { get; set; }
        public string Mp3Path { get; set; }
        public string PdfPath { get; set; }
        public string Opis { get; set; }

        public int AdministratorID { get; set; }


    }
}
