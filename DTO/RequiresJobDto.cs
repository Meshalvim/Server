using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace DTO
{
   public class RequiresJobDto
    {
        public int id_req_to_job { get; set; }
        public int id_job           { get; set; }
        public int id_requirment { get; set; }
     public double score            { get; set; }

        public RequiresJobDto(int id_req_to_job, int id_job, int id_requirment, double score)
        {
            this.id_req_to_job = id_req_to_job;
            this.id_job = id_job;
            this.id_requirment = id_requirment;
            this.score = score;
        }

        public requiers_to_jobs convertTorequiers_to_jobs()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<RequiresJobDto, requiers_to_jobs>());
            var mapper = new Mapper(config);
            return mapper.Map<requiers_to_jobs>(this);
        }
        public static RequiresJobDto convertTorequiers_to_jobs_dto(requiers_to_jobs s)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<requiers_to_jobs, RequiresJobDto>());
            var mapper = new Mapper(config);
            return mapper.Map<RequiresJobDto>(s);
        }
    }
}
