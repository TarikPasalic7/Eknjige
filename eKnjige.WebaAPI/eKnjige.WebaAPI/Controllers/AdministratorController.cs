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
    public class AdministratorController : BaseController<Model.Administrator, object>
    {
        public AdministratorController(IService<Model.Administrator,object> _service) : base(_service)
        {
        }
    }
}