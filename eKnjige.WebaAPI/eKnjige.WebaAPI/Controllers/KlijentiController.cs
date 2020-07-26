
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKnjige.Model;
using eKnjige.Model.Requests;
using eKnjige.WebaAPI.Data;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKnjige.WebaAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KlijentiController : ControllerBase
    {

        private readonly IKlijentService _service;
        public KlijentiController(IKlijentService service)
        {
            _service = service;
        }


        [HttpGet]
        public List<Model.Klijent> Get([FromQuery] Model.Requests.KlijentiSearchRequest request)
        {
            return _service.Get(request);
        }

      
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public Model.Klijent Insert(Model.KlijentInsertRequest request)
        {
            return _service.Insert(request);
        }

       
        [HttpPut("{id}")]
        
        public Model.Klijent Update(int id, [FromBody]Model.KlijentUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Klijent GetById(int id)
        {
            return _service.GetbyId(id);
        }

        [HttpGet("Profil")]
        [Authorize]
        public Model.Klijent Profil()
        {
            return _service.Profil();
        }


        //Get Autor
        //[HttpGet]
        //public ActionResult<List<Model.Klijent>> get()
        //{
        //    var list = klijentsv.Get();

        //    return Ok(list);
        //}

        //[HttpGet]
        //public ActionResult<List<Model.Klijent>> get([FromQuery]Model.Requests.KlijentiSearchRequest search)
        //{
        //    var list = klijentsv.Get(search);

        //    return Ok(list);
        //}
        //[HttpGet("{id}")]
        //public ActionResult<Model.Klijent> GetById(int id)
        //{
        //    var klijent = klijentsv.Get(id);



        //    return klijent;
        //}

        //[HttpPost]
        //public ActionResult<Model.Klijent> Insert(Model.KlijentInsertRequest kl)
        //{

        //    var klijentreq = klijentsv.Insert(kl);

        //    return klijentreq;
        //}




        //[HttpPut("{id}")]
        //public ActionResult<Model.Klijent> Update(int id, Model.KlijentInsertRequest request)
        //{

        //    var klijentupdate = klijentsv.Update(id, request);

        //    return klijentupdate;
        //}

    }
}