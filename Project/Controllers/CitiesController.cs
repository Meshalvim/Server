using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Project;
using DTO;
using DAL;
using Bll;

namespace Project.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class CitiesController : ApiController
    {
    //[EnableCors(origins:"*",headers:"*",methods:"*")]
        // GET: api/Cities
        public object Get()
        {
            var r = DB.GetCitiee();
            return r;
            //return "working";
        }

    }
}
