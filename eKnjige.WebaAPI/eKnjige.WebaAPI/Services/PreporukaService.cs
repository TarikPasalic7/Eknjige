
using AutoMapper;
using eKnjige.WebaAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
    public class PreporukaService : IPreporukaService
    {
        private readonly AppContext _context;

        private readonly IMapper _mapper;

        private int pozitivnaOcjena = 3;
        private int brojRezultata = 5;

        public PreporukaService(AppContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.EKnjiga> GetPreporuceneKnjige(int knjigaId)
        {
            int KorisnikId = Security.BasicAuthenticationHandler.PrijavljeniKlijent.KlijentID;

            try
            {
                if (KorisnikId == 0)
                {
                    throw new System.Exception();
                }

                List<KlijentKnjigaOcijena> listaOcjena = _context.KlijentKnjigaOcijene.Where(x => x.KlijentID == KorisnikId)
                    .Include(x=>x.Klijent)
                    .Include(x => x.Eknjiga)
                    .ToList();

                List<KlijentKnjigaOcijena> listaPozitivnihOcjena = listaOcjena
                    .Where(x => x.Ocjena >= pozitivnaOcjena)
                    .ToList();

                if (listaPozitivnihOcjena.Count() > 0)
                {
                    List<Kategorija> jedinstveneKategorije = new List<Kategorija>();
                    foreach (var item in listaPozitivnihOcjena)
                    {
                        var igraKategorije = _context.EKnjigaKategorije.Where(m => m.EKnjigaID == item.EKnjigaID)
                            .Select(g => g.Kategorija)
                            .ToList();

                        foreach (var Kategorija in igraKategorije)
                        {
                            // Add only unique items to the list (no duplicates)
                            bool dodaj = true;
                            for (int i = 0; i < jedinstveneKategorije.Count; i++)
                            {
                                if (Kategorija.Naziv == jedinstveneKategorije[i].Naziv)
                                {
                                    dodaj = false;
                                }
                            }

                            if (dodaj)
                            {
                                jedinstveneKategorije.Add(Kategorija);
                            }
                        }
                    }

                    List<EKnjiga> konacnaLista = new List<EKnjiga>();
                    foreach (var item in jedinstveneKategorije)
                    {
                        var igreUKategoriji = _context.EKnjigaKategorije
                            .Where(g => g.KategorijaID == item.KategorijaID)
                            .Select(x => x.Eknjiga)
                            .ToList();

                        foreach (var Igra in igreUKategoriji)
                        {
                            bool dodaj = true;
                            for (int i = 0; i < konacnaLista.Count; i++)
                            {
                                if (Igra.Naziv == konacnaLista[i].Naziv)
                                {
                                    dodaj = false;
                                }

                            }

                            foreach (var ocjena in listaOcjena)
                            {
                                if (Igra.Naziv == ocjena.Eknjiga.Naziv)
                                {
                                    dodaj = false;
                                }
                            }

                            if (dodaj)
                            {
                                konacnaLista.Add(Igra);
                            }
                        }
                    }

                    konacnaLista = konacnaLista.OrderBy(media => System.Guid.NewGuid()).Take(brojRezultata).ToList();

                   
                    List<Model.EKnjiga> listaKnjiga = _mapper.Map<List<Model.EKnjiga>>(konacnaLista);
                   

                    return listaKnjiga;
                }
                throw new System.Exception();
            }
            catch
            {
                var lista = _context.EKnjige.OrderBy(media => System.Guid.NewGuid()).Take(brojRezultata).ToList();

                // ucitavanje slika za svaku igru
                List<Model.EKnjiga> listaKnjiga = _mapper.Map<List<Model.EKnjiga>>(lista);
             

                return listaKnjiga;
            }
        }

       
    }
}
