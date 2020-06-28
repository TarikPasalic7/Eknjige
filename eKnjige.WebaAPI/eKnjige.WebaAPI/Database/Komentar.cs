using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKnjige.WebaAPI
{
    public class Komentar
    {
        [Key]
        public int KomentarId { get; set; }

        public string komentar  { get; set; }

       public  DateTime DatumKomentara { get; set; }

        [ForeignKey("Klijent")]
        public int KlijentID { get; set; }
        public Klijent Klijent { get; set; }


        [ForeignKey("EKnjiga")]
        public int EKnjigaID { get; set; }
        public EKnjiga EKnjiga { get; set; }

    }
}
