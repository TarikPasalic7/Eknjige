﻿using System;


namespace eKnjige.Model
{
    public class PrijedlogKnjigaRequest
    {


        public int PrijedlogKnjigeID { get; set; }

        public DateTime Datum { get; set; }
        public bool Prihvacen { get; set; }
        public bool Odgovoren { get; set; }
        public string Naziv { get; set; }

      

        public int KlijentID { get; set; }

        

        

      

       

        public int AdministratorID { get; set; }
    }
}
