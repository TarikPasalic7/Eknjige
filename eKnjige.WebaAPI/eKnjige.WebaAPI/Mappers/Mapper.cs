using AutoMapper;
using eKnjige.WebaAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Mappers
{
    public class Mapper:Profile
    {

        public Mapper()
        {

            CreateMap<Klijent, Model.Klijent>().ReverseMap();
            CreateMap<TipFajla, Model.TipFajla>().ReverseMap();
            CreateMap<Kategorija, Model.Kategorija>().ReverseMap();
            CreateMap<Kategorija, Model.Requests.KategorijaInertRequest>().ReverseMap();
            CreateMap<Uloga, Model.Uloga>().ReverseMap();
            CreateMap<Uloga, Model.UlogeRequest>().ReverseMap();
            CreateMap<Klijent, Model.KlijentInsertRequest>().ReverseMap();
            CreateMap<Autor, Model.Autor>().ReverseMap();
            CreateMap<EKnjiga, Model.EKnjiga>().ReverseMap();
            CreateMap<EKnjiga, Model.Requests.EKnjigaInsertRequest>().ReverseMap();
            CreateMap<Grad, Model.Grad>().ReverseMap();
            CreateMap<Spol, Model.Spol>();
            CreateMap<Drzava, Model.Drzava>().ReverseMap();
            CreateMap<EKnjiga, Model.Requests.eKnjigeSearchRequest>().ReverseMap();
            
        }
    }
}
