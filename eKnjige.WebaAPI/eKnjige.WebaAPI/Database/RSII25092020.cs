
using System;
using System.ComponentModel.DataAnnotations;

namespace eKnjige.WebaAPI
{
    public class RSII25092020
    {
        [Key]

        public int KlijentID { get; set; }
        public Klijent Klijent { get; set; }

        public DateTime Datumkreiranjazapisa { get; set; }
        public bool PotencijalnoMaliciozan { get; set; }
    }
}