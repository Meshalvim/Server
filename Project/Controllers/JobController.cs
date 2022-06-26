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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class JobController : ApiController
    {
        // GET: api/Job/5
        public RequestResult Get([FromUri]string id)
        {
            RequestResult result = new RequestResult();
            result = DB.GetJob(id);
            return result;
        }

        // POST: api/Job
        public RequestResult Post([FromBody] FullCompanyJob companyJob)
        {
            RequestResult result = new RequestResult();
            result = DB.InsertFullCompanyJob(companyJob);
            return result;
        }

        // PUT: api/Job/5
        public RequestResult Put([FromUri] string id, [FromBody] FullCompanyJob companyJob)
        {
            FullCompanyJob oldCompanyJob= DB.GetJob(id).data as FullCompanyJob;
            bool deleted = DB.DeleteJob(id);
            oldCompanyJob.Company.name_company = companyJob.Company.name_company;
            oldCompanyJob.Company.password_company = companyJob.Company.password_company;
            oldCompanyJob.Job.id_city = companyJob.Job.id_city;
            RequestResult result = DB.InsertFullCompanyJob(oldCompanyJob);
            return deleted ? result : new RequestResult { data = "failed", message = "not deleted", status = false };
        }

        // DELETE: api/Job/5
        public bool Delete([FromUri] string id)
        {
            bool deleted = DB.DeleteJob(id);
            return deleted;
        }

    }
}
