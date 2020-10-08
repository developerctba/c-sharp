using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class CorreiosController : ApiController
    {
        [Route("api/correios/{cep}")]
        [HttpGet, HttpPost]
        public HttpResponseMessage GetCEP(string cep)
        {
            var correios = new CorreiosService.AtendeClienteClient();
            var consulta = correios.consultaCEP(cep);
            return Request.CreateResponse<Object>(HttpStatusCode.OK, consulta);
        }

    }
}
