using Bll.HelpClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
using System.Web.Http.Cors;

namespace Project.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LogInController : ApiController
    {
        // POST: api/LogIn
        public RequestResult Post([FromBody]LogIn details)
        {
            RequestResult result=  DB.LogIn(details);
            return result;
        }

    }
}
