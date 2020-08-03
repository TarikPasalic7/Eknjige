using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKnjige.Model;
using eKnjige.WebaAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKnjige.WebaAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EKnjigaTipFajlaController : BaseCRUDController<Model.EKnjigaTip, Model.EKnjigaTip, Model.EKnjigaTipRequest, Model.EKnjigaTipRequest>
    {
        public EKnjigaTipFajlaController(ICRUDService<Model.EKnjigaTip, Model.EKnjigaTip, EKnjigaTipRequest, EKnjigaTipRequest> _service) : base(_service)
        {
        }
    }
}