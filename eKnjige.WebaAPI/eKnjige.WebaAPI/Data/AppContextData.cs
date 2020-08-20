
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Data
{
    public partial class AppContext
    {

      
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drzava>().HasData(new Drzava()
            {
                DrzavaID = 1,
                Naziv = "BiH"

            });
        }
    }
}
