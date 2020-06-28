using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKnjige.Model;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKnjige.WebaAPI.Controllers
{
    public class AutorController : BaseController<Model.Autor, object>
    {
        public AutorController(IService<Model.Autor, object> _service) : base(_service)
        {
        }
    }
}