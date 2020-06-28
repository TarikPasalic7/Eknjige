using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKnjige.WebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipFajlaController : BaseCRUDController<Model.TipFajla, object, Model.TipFajla, Model.TipFajla>
    {
        public TipFajlaController(ICRUDService<Model.TipFajla, object, Model.TipFajla, Model.TipFajla> _service) : base(_service)
        {
        }
    }
}