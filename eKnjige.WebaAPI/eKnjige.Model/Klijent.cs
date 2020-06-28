using System;
using System.ComponentModel.DataAnnotations;

namespace eKnjige.Model
{
    public class Klijent
    {


        public int KlijentID { get; set; }

        [Required]
        public string Ime { get; set; }


        [Required]
        public string Prezime { get; set; }


        [Required]
        public string KorisnickoIme { get; set; }


        [Required]
        public string Email { get; set; }

        public string Jmbg { get; set; }

        public DateTime DatumRodjenja { get; set; }

       

        public int SpolID { get; set; }

      


        public int GradID { get; set; }

       

       

    }
}
