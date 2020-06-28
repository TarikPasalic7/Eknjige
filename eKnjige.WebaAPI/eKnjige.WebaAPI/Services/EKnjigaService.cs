using AutoMapper;
using eKnjige.Model.Requests;
using eKnjige.WebaAPI.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Services
{
    public class EKnjigaService : IEKnjigaService
    {
        private readonly AppContext db;
        private readonly IMapper mapper;

        public EKnjigaService(AppContext _db,IMapper map)
        {
            db = _db;
            mapper = map;

        }
  

        public List<Model.EKnjiga> Get(eKnjigeSearchRequest search)
        {
            var query = db.Set<EKnjiga>().AsQueryable();


            if (!string.IsNullOrWhiteSpace(search.Naziv))
            {

                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }



            var list = query.ToList();
            return mapper.Map<List<Model.EKnjiga>>(list);

        }

        public Model.EKnjiga getById(int id)
        {
            var eknjiga = db.EKnjige.Find(id);

            return mapper.Map<Model.EKnjiga>(eknjiga);
        }

        public Model.EKnjiga Insert( Model.Requests.EKnjigaInsertRequest request)
        {
            var eknjiga = mapper.Map<EKnjiga>(request);
            db.EKnjige.Add(eknjiga);
            db.SaveChanges();
            return mapper.Map<Model.EKnjiga>(eknjiga);
        }
    }
}
