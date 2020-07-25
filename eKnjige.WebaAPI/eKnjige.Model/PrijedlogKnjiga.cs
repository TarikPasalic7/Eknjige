using System;


namespace eKnjige.Model
{
    public class PrijedlogKnjiga
    {


        public int PrijedlogKnjigeID { get; set; }

        public DateTime Datum { get; set; }
        public bool Prihvacen { get; set; }
        public bool Odgovoren { get; set; }
        public string Naziv { get; set; }

      

        public int KlijentID { get; set; }

        public Klijent Klijent { get; set; }

        

      

        public Klijent Administrator { get; set; }

        public int AdministratorID { get; set; }
    }
}
