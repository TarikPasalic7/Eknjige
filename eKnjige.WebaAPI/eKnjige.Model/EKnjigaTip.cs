

namespace eKnjige.Model
{
    public class EKnjigaTip
    {
        
        public int EKnjigaTipID { get; set; }

       
        public int EKnjigaID { get; set; }
        public EKnjiga Eknjiga { get; set; }

     
        public int TipFajlaID { get; set; }
        public TipFajla Tipfajla { get; set; }

    }
}
