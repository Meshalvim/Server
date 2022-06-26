using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.HelpClasses;
using DAL;
using DTO;

namespace Bll
{
    public class DB
    {
        static WORKERSEntities ent = new WORKERSEntities();
        public static List<candidate> GetAllCandidates()
        {
            List<candidate> candidates = ent.candidates.Select(x => x).ToList();
            return candidates;
        }
        public static List<job> GetAllJobs()
        {
            List<job> jobs = ent.jobs.Select(x => x).ToList();
            return jobs;
        }

        public static void RemoveScheduling()
        {
            ent.schedulings.RemoveRange(ent.schedulings.Select(s=>s));
            ent.SaveChanges();
        }

        public static List<company> GetAllCompanies()
        {
            List<company> companies = ent.companies.Select(x => x).ToList();
            return companies;
        }
        public static List<area> GetAreas()
        {

            List<area> areas = ent.areas.Select(x => x).ToList();
            return areas;
        }
        public static List<CityDto> GetCitiee()
        {
            List<CityDto> cities = ent.cities.ToList().Select(x => CityDto.convertTocity_dto(x)).ToList();
            return cities;
        }


        public static List<city> GetCitie()
        {
            List<city> cities = ent.cities.Select(x => x).ToList();
            return cities;
        }
        public static List<string> GetCitiesNames()
        {
            List<string> cities = ent.cities.Select(x => x.name_city).ToList();
            return cities;
        }
        public static RequestResult GetCities()
        {
            RequestResult requestResult = new RequestResult();
            try
            {
                List<city> cities = ent.cities.Select(x => x).ToList();
                requestResult.data = cities;
                requestResult.status = true;
                requestResult.message = "secceed";
            }
            catch (Exception ex)
            {
                requestResult.data = null;
                requestResult.status = false;
                requestResult.message = "Not secceed";
            }
            return requestResult;
        }
        public static List<score_of_jobs> GetScore()
        {
            List<score_of_jobs> scores = ent.score_of_jobs.Select(x => x).ToList();
            return scores;
        }
        public static RequestResult GetCandidate(string name)
        {
            RequestResult requestResult = new RequestResult();
            try
            {
                candidate c = ent.candidates.Where(x => x.name_ == name).Select(x => x).FirstOrDefault();
                CandidaleDto candidate = CandidaleDto.convertTocandidate_dto(c);
                List<favorite_req> reqs = ent.favorite_req.Where(req => req.id_candidate == candidate.id_candidate).ToList();
                List<FavoriteReqDto> reqDtos = reqs.Select(req => FavoriteReqDto.convertTofavorite_reqs_dto(req)).ToList();
                FullCandidate fullCandidate = new FullCandidate { Candidate = candidate, FavoriteReqs = reqDtos };
                requestResult.data = fullCandidate;
                requestResult.status = true;
                requestResult.message = "secceed";
            }
            catch (Exception ex)
            {
                requestResult.data = null;
                requestResult.status = false;
                requestResult.message = "Not secceed";
            }
            return requestResult;
        }
        public static RequestResult GetJob(string name)
        {
            RequestResult requestResult = new RequestResult();
            try
            {
                job job = ent.jobs.FirstOrDefault(x => x.company.name_company == name);
                int? companyId = job.id_comp;
                JobDto jobDto = JobDto.convertTojob_dto(job);
                score_of_jobs score = ent.score_of_jobs.FirstOrDefault(scoreJob => scoreJob.id_job == job.id_job);
                ScoreOfJobDto scoreDto = ScoreOfJobDto.convertToscore_dto(score);
                company company = ent.companies.FirstOrDefault(comp => comp.id_company == companyId);
                CompanyDto companyDto = CompanyDto.convertTocompany_dto(company);
                List<requiers_to_jobs> reqs = ent.requiers_to_jobs.Where(req => req.id_job == job.id_job).ToList();
                List<RequiresJobDto> reqDtos = reqs.Select(req => RequiresJobDto.convertTorequiers_to_jobs_dto(req)).ToList();
                FullCompanyJob fullCompanyJob = new FullCompanyJob { Job = jobDto, scoreOfJob = scoreDto, requires = reqDtos, Company = companyDto };
                requestResult.data = fullCompanyJob;
                requestResult.status = true;
                requestResult.message = "secceed";
            }
            catch (Exception ex)
            {
                requestResult.data = null;
                requestResult.status = false;
                requestResult.message = "Not secceed";
            }
            return requestResult;
        }
        public static bool InsertCandidate(CandidaleDto candidale)
        {
            try
            {
                candidate candidate = candidale.convertTocandidates();
                ent.candidates.Add(candidate);
                ent.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool DeleteCandidate(string name)
        {
            try
            {
                candidate candidate = ent.candidates.FirstOrDefault(candid => candid.name_ == name);
                List<favorite_req> reqs = ent.favorite_req.Where(req => req.id_candidate == candidate.id_candidate).ToList();
                if (reqs == null)
                    return false;
                ent.favorite_req.RemoveRange(reqs);
                if (candidate == null)
                    return false;
                candidate = ent.candidates.Remove(candidate);
                ent.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static RequestResult GetRequirements()
        {
            RequestResult result = new RequestResult();
            try
            {
                List<requirement> requirements = ent.requirements.Select(x => x).ToList();
                List<RequiermentsDto> requiermentsDtos = requirements.Select(x => RequiermentsDto.convertTorequirements_dto(x)).ToList();
                result.data = requiermentsDtos;
                result.message = "secceed";
                result.status = true;
            }
            catch
            {
                result.data = null;
                result.message = "Not secceed";
                result.status = false;
            }
            return result;
        }
        public static RequestResult GetGender()
        {
            RequestResult result = new RequestResult();
            try
            {
                List<gender> g = ent.genders.Select(x => x).ToList();
                List<GenderDto> genders = g.Select(x => GenderDto.convertTogender_dto(x)).ToList();
                result.data = genders;
                result.message = "seccess";
                result.status = true;
                return result;
            }
            catch
            {
                result.data = null;
                result.message = "not seccess";
                result.status = false;
                return result;
            }
        }
        public static bool InsertFavoriteReq(FavoriteReqDto favoriteReq)
        {
            try
            {
                favorite_req requirement = favoriteReq.convertTofavorite_reqs();
                ent.favorite_req.Add(requirement);
                ent.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static RequestResult InsertJobs(JobDto job)
        {
            RequestResult result = new RequestResult();
            try
            {
                job job_ = job.convertToJob();
                ent.jobs.Add(job_);
                //job dataJob = ent.jobs.FirstOrDefault(j => j.id_comp == job.id_comp); 
                ent.SaveChanges();
                result.data = job;
                result.status = true;
                result.message = "secceed";
                return result;
            }
            catch (Exception e)
            {
                result.data = null;
                result.status = false;
                result.message = "The password is exist";
                return result;
            }
        }
        public static bool InsertScoreOfJob(ScoreOfJobDto scoreOfJobDto)
        {
            try
            {
                score_of_jobs score = scoreOfJobDto.convertToScoreOfJobs();
                ent.score_of_jobs.Add(score);
                ent.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool InsertCompany(CompanyDto company)
        {
            try
            {
                company comp = company.convertTocompany();
                ent.companies.Add(comp);
                ent.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool InsertReqOfJob(RequiresJobDto requiersJobs)
        {
            try
            {
                requiers_to_jobs requiers = requiersJobs.convertTorequiers_to_jobs();
                ent.requiers_to_jobs.Add(requiers);
                ent.SaveChanges();
                return true;
        }
            catch
            {
                return false;
            }
        }

        public static RequestResult GetScheduling(int idCompany)
        {
            RequestResult result = new RequestResult();
            try
            {
                List<scheduling> scheduling = ent.schedulings.Select(x => x).Where(x => x.id_job == idCompany).ToList();
                result.data = scheduling;
                result.message = "seccees";
                result.status = true;
            }
            catch
            {
                result.data = null;
                result.message = "not seccees";
                result.status = false;
            }
            return result;
        }

        public static RequestResult GetScheduling()
        {
            //MainAlg alg = new MainAlg();
            RequestResult result = new RequestResult();
            try
            {
                List<scheduling> s = ent.schedulings.Select(x => x).ToList();
                List<SchedulingDto> scheduling = s.Select(x => SchedulingDto.convertToscheduling_dto(x)).ToList();
                result.data = scheduling;
                result.message = "seccees";
                result.status = true;
            }
            catch
            {
                result.data = null;
                result.message = "not seccees";
                result.status = false;
            }
            return result;
        }

        public static RequestResult LogIn(LogIn details)
        {
            RequestResult result = new RequestResult();
            bool found, isCompany, isCandidate;
            try
            {
                candidate candidate = ent.candidates.FirstOrDefault(candid => candid.name_ == details.Name && candid.password_ == details.Password);
                company company = ent.companies.FirstOrDefault(comp => comp.name_company == details.Name && comp.password_company == details.Password);
                found = candidate != null || company != null;
                isCompany = found && company != null;
                isCandidate = found && candidate != null;
                if (isCandidate)
                {
                    CandidaleDto candidaleDto = CandidaleDto.convertTocandidate_dto(candidate);
                    FullCandidate fullCandidate = new FullCandidate { Candidate = candidaleDto };
                    result.data = fullCandidate;
                }
                else if (isCompany)
                {
                    CompanyDto companyDto = CompanyDto.convertTocompany_dto(company);
                    job job = ent.jobs.FirstOrDefault(j => j.id_comp == company.id_company);
                    JobDto jobDto = JobDto.convertTojob_dto(job);
                    score_of_jobs score = ent.score_of_jobs.FirstOrDefault(j => j.id_job == job.id_job);
                    ScoreOfJobDto scoreDto = ScoreOfJobDto.convertToscore_dto(score);
                    FullCompanyJob fullCompany = new FullCompanyJob { Company = companyDto, Job = jobDto, scoreOfJob = scoreDto };
                    result.data = fullCompany;
                }
                //result.data = isCompany ? companyDto : isCandidate ? candidaleDto : obj;
                result.message = isCompany ? "company" : isCandidate ? "candidate" : "";
                result.status = found;
            }
            catch (Exception e)
            {
                result.data = null;
                result.message = "not seccees";
                result.status = false;
            }
            return result;
        }
        public static RequestResult InsertFullCandidate(FullCandidate fullCandidate)
        {
            RequestResult failedResult = new RequestResult { status = false, message = "failed", data = null };
            if (LogIn(new LogIn { Name = fullCandidate.Candidate.name_, Password = fullCandidate.Candidate.password_ }).data != null)
                return failedResult;
            bool flag1 = InsertCandidate(fullCandidate.Candidate);
            if (!flag1)
                return failedResult;
            CandidaleDto candidaleDto = CandidaleDto.convertTocandidate_dto(ent.candidates.FirstOrDefault(c => c.name_ == fullCandidate.Candidate.name_));
           int idCandidate = candidaleDto.id_candidate;
            fullCandidate.Candidate = candidaleDto;
            foreach (var req in fullCandidate.FavoriteReqs)
            {
                req.id_candidate = idCandidate;
                bool flag = InsertFavoriteReq(req);
                if (!flag)
                    return failedResult;
            }
            return new RequestResult { data=fullCandidate, message="success", status=true };
        }
        public static RequestResult InsertFullCompanyJob(FullCompanyJob companyJob)
        {
            LogIn logIn = new LogIn() { Name = companyJob.Company.name_company, Password = companyJob.Company.password_company };
            if (LogIn(logIn).data != null)
                return new RequestResult { data = "Ununique id", message = "", status = false };
            RequestResult result = new RequestResult();
            InsertCompany(companyJob.Company);
            company company = ent.companies.FirstOrDefault(c => c.name_company == companyJob.Company.name_company);
            companyJob.Company = CompanyDto.convertTocompany_dto(company);
            //object companyObj = LogIn(new HelpClasses.LogIn { Name = companyJob.Company.name_company, Password = companyJob.Company.password_company }).data;
            //int companyId = ent.companies.FirstOrDefault(c => c.name_company == companyJob.Company.name_company).id_company;
            companyJob.Job.id_comp = companyJob.Company.id_company;
            InsertJobs(companyJob.Job);
            companyJob.Job = JobDto.convertTojob_dto(ent.jobs.FirstOrDefault(j => j.id_comp == companyJob.Company.id_company));
            companyJob.scoreOfJob.id_job = companyJob.Job.id_job;
            InsertScoreOfJob(companyJob.scoreOfJob);
            companyJob.scoreOfJob =ScoreOfJobDto.convertToscore_dto(ent.score_of_jobs.FirstOrDefault(s => s.id_job == companyJob.Job.id_job));
            foreach (var req in companyJob.requires)
            {
                req.id_job = companyJob.Job.id_job;
                InsertReqOfJob(req);
            }
            result.data = companyJob;
            result.status = true;
            return result;
        }

        public static bool DeleteJob(string name)
        {
            try
            {
                company company = ent.companies.FirstOrDefault(c => c.name_company == name);
                job job = ent.jobs.FirstOrDefault(j => j.id_comp == company.id_company);
                int idJob = job.id_job;
                List<requiers_to_jobs> reqs = ent.requiers_to_jobs.Where(req => req.id_job == idJob).ToList();
                score_of_jobs score = ent.score_of_jobs.FirstOrDefault(s => s.id_job == idJob);
                if (reqs == null)
                    return false;
                ent.requiers_to_jobs.RemoveRange(reqs);
                if (score == null)
                    return false;
                score = ent.score_of_jobs.Remove(score);
                if (company == null)
                    return false;
                company = ent.companies.Remove(company);
                if (job == null)
                    return false;
                job = ent.jobs.Remove(job);
                ent.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
