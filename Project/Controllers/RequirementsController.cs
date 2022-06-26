using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Project;
using DTO;
using Bll;

namespace Project.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RequirementsController : ApiController
    {
        [HttpGet]
        // GET: api/Requirements
        public RequestResult Get()
        {
            RequestResult result = new RequestResult();
            result = DB.GetRequirements();
            return result;
        }
    }
}
