

namespace eKnjige.Model
{
    public class Grad
    {
        
        public int Id { get; set; }
        public string Naziv { get; set; }

      
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }
    }
}
