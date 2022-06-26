using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Bll;
using DTO;
using Project;

namespace Project.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GenderController : ApiController
    {
        // GET: api/Gender
        public RequestResult Get()
        {
            RequestResult result = new RequestResult();
            result = DB.GetGender();
            return result;
        }

    }
}
