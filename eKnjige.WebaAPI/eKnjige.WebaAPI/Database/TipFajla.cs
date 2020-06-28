

using System.ComponentModel.DataAnnotations;

namespace eKnjige.WebaAPI
{
    public class TipFajla
    {
        [Key]
        public int TipFajlaID { get; set; }
        public string Naziv { get; set; }
    }
}
