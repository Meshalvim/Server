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
using Bll.HelpClasses;

namespace Project.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*") ]
    public class CandidateController : ApiController
    {
        // GET: api/Candidate/5
        [HttpGet]
        public RequestResult Get([FromUri]string id)
        {
            RequestResult result = new RequestResult();
            result= DB.GetCandidate(id);
            return result;
        }

        // POST: api/Candidate
        [HttpPost]
        public RequestResult Post([FromBody]FullCandidate fullCandidate)
        {
            RequestResult result = DB.InsertFullCandidate(fullCandidate);
            return result;
        }

        // PUT: api/Candidate/5
        [HttpPut]
        public RequestResult Put([FromUri]string id, [FromBody]FullCandidate candidale)
        {
            FullCandidate oldCandidate = DB.GetCandidate(id).data as FullCandidate;
            bool deleted = DB.DeleteCandidate(id);
            oldCandidate.Candidate = candidale.Candidate;
            RequestResult result = DB.InsertFullCandidate(oldCandidate);
            return deleted? result : new RequestResult { data = "failed", message = "not deleted", status = false };
        }

        // DELETE: api/Candidate/5
        [HttpDelete]
        public bool Delete([FromUri]string id)
        {
            bool deleted = DB.DeleteCandidate(id);
            return deleted;
        }

        //[HttpGet]
        ////[Route("api/Candidate/Schedule")]
        //public RequestResult Schedule()
        //{
        //    MainAlg alg = new MainAlg();
        //    alg.setScore();
        //    RequestResult re = new RequestResult();
        //    return re;
        //}
    }
}
